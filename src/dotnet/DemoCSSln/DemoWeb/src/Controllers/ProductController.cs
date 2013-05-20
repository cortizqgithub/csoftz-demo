/*==========================================================================*/
/* Source File:   PRODUCTCONTROLLER.CS                                      */
/* Description:   Controller Class for Products page.                       */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                          */
/* Date:          Dec.03/2010                                               */
/* Last Modified: Dec,08/2010                                               */
/* Version:       1.3                                                       */
/* Copyright (c), 2010 CSoftZ                                               */
/*==========================================================================*/

/*===========================================================================
History
Dec.03/2010 COQ  File created.
============================================================================*/

using System;
using System.Web.Mvc;
using AutoMapper;
using CSoftZ.Demo.Common.Helper.Consts;
using CSoftZ.Demo.Domain;
using CSoftZ.Demo.Domain.View.Model;
using CSoftZ.Demo.Interface;
using Spring.Objects.Factory;

namespace CSoftZ.Demo.Web.Controllers {
    /// <summary>
    /// Controller class for Products Page.
    /// </summary>
    public class ProductController : AbstractSimpleController, IInitializingObject {
        // Injected by IoC. Access to Product services.
        private IProductDataService _productService;

        // Injected by IoC. Access to YesNo Services.
        private IYesNoValueService _yesNoValueService;

        // Injected by IoC. Access to ProductFilterCriteria Services.
        private IProductFilterCriteriaService _productFilterCriteriaService;

        // Injected by IoC. Access to PageSize Services.
        private IPageSizeValueService _pageSizeValueService;

        /// <summary>
        /// Define mapping for domain objects.
        /// </summary>
        private void SetupMappers() {
            Mapper.Reset();
            Mapper.CreateMap<ProductViewModel, ProductInfo>();
            Mapper.CreateMap<ProductInfo, ProductViewModel>();
        }

        ///  <summary>
        /// If the object reference dependency properties are not properly set, 
        /// an exception is thrown indicating that they are required to be 
        /// configured for the bean to work properly.
        /// </summary>
        /// <remarks></remarks>
        public void AfterPropertiesSet() {
            base.AfterPropertiesSet();
            if (_productService == null) {
                throw new Exception("productService property is not assigned.");
            }
            if (_yesNoValueService == null) {
                throw new Exception("yesNoValueService property is not assigned.");
            }
            if (_productFilterCriteriaService == null) {
                throw new Exception("productFilterCriteriaService property is not assigned.");
            }
            if (_pageSizeValueService == null) {
                throw new Exception("pageSizeValueService property is not assigned.");
            }
        }

        /// <summary>
        /// Welcome page for Products.
        /// </summary>
        /// <returns>Welcome page view.</returns>
        public ActionResult Index() {
            Boolean useSearch = false;
            ProductViewModel p = new ProductViewModel();
            ViewData[ViewConstants.VIEWDATA_FILTERCRITERIALIST] = _productFilterCriteriaService.GetAll();
            ViewData[ViewConstants.VIEWDATA_PAGESIZELIST] = _pageSizeValueService.GetAll();
            if (Request != null) {
                object sc = Request[GlobalConstants.REQUEST_SEARCH_CRITERIA_CB_HIDDEN];
                if (sc != null) {
                    string s = sc.ToString();
                    p.SearchCriteriaHidden = s;
                    p.SearchCriteria = Convert.ToInt32(s);
                }

                object sd = Request[GlobalConstants.REQUEST_SEARCH_CRITERIA_DATA_HIDDEN];
                if (sd != null) {
                    string s = sd.ToString();
                    p.SearchDataHidden = s;
                    p.SearchData = s;
                }

                object ps = Request[GlobalConstants.REQUEST_PAGE_SIZE];
                if (ps != null) {
                    string s = ps.ToString();
                    p.PageSize = Convert.ToInt32(s);
                }
                useSearch = true;

                // Now, if user has decided to use ALL, then resort to get all records instead.
                if (p.SearchCriteria == 0) {
                    useSearch = false;
                    p.SearchCriteriaHidden = "0";
                    p.SearchDataHidden = "";
                }
            }

            // Now it is time to infer if it is a full list or a searched list.
            if (useSearch) {
                p.ProductList = _productService.GetAll();
            }
            else {
                p.ProductList = _productService.GetAll();
            }
            return View(p);
        }

        /// <summary>
        ///  This is the entry point action to the Controller. When called it 
        ///  is because user activated the search criteria.</summary>
        /// <param name="m">Information to use.</param>
        /// <returns>Welcome page view.</returns>
        [HttpPost]
        public ActionResult Index(ProductViewModel m) {
            // Let//s first check if a DELETE is in progress.
            if (Request != null) {
                // NOTE: if HTML Input is BUTTON in ASP.NET MVC it is not sent
                // in a POST request, that is why I opted to used a hidden 
                // field to actually know if a DELETE button was used and it is
                // the one to test.
                var delRecs = Request[GlobalConstants.REQUEST_FORM_DELETE_RECORDS];
                var delRecsUsed = Request[GlobalConstants.REQUEST_FORM_DEL_RECS_USED];
                if (delRecsUsed != null) {
                    // Up to this point, a record deletion is in progress.
                    var recsToDelList = Request[GlobalConstants.REQUEST_FORM_REC_TO_DEL];
                    if (recsToDelList != null) {
                        var actionSuccess = true;
                        string s = recsToDelList.ToString();
                        String[] aiIds = s.Split(',');
                        foreach (var it in aiIds) {
                            int id = Convert.ToInt32(it);
                            try {
                                _productService.Remove(id);
                            }
                            catch (Exception) {
                                actionSuccess = false;
                            }
                        }

                        // Now compose message to view on screen.
                        if (actionSuccess) {
                            ViewData[ViewConstants.VIEWDATA_MSGBOX] = ComposeMsgBox("One or more Products were successfully removed..", "error", GlobalConstants.MSGBOX_DELAY_MILISECS);
                        }
                        else {
                            ViewData[ViewConstants.VIEWDATA_MSGBOX] = ComposeMsgBox("One or more Products were not successfully removed..", "error", GlobalConstants.MSGBOX_DELAY_MILISECS);
                        }
                    }
                } 
            }
            ProductViewModel p = new ProductViewModel();
            ViewData[ViewConstants.VIEWDATA_FILTERCRITERIALIST] = _productFilterCriteriaService.GetAll();
            ViewData[ViewConstants.VIEWDATA_PAGESIZELIST] = _pageSizeValueService.GetAll();
            if (p.PreserveCriteria == GlobalConstants.NO_VALUE) {
                p.SearchCriteria = m.SearchCriteria;
                p.SearchData = m.SearchData;
                p.SearchCriteriaHidden = Convert.ToString(m.SearchCriteria);
                p.SearchDataHidden = m.SearchData;
            }
            p.PageSize = m.PageSize;

            if (p.SearchCriteria == 0) {
                p.ProductList = _productService.GetAll();
            } else {
                p.ProductList = _productService.GetAll(); // findBy
            }
            return View(p);
        }

        /// <summary>
        /// Action to create an empty record from model.
        /// </summary>
        /// <returns>View with an empty product page</returns>
        public ActionResult Create() {
            ViewData[ViewConstants.VIEWDATA_YESNOVALUELIST] = _yesNoValueService.GetAll();
            ProductViewModel p = new ProductViewModel();
            return View(p);
        }

        /// <summary>
        /// Action to submit contents to be stored in database.
        /// </summary>
        /// <param name="m">Information to save</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Create(ProductViewModel m) {
            SetupMappers();
            //ViewData[ViewConstants.VIEWDATA_MSGBOX] = "";
            //ViewData[ViewConstants.VIEWDATA_YESNOVALUELIST] = _yesNoValueService.GetAll();
            if (!ModelState.IsValid) {
                ViewData[ViewConstants.VIEWDATA_MSGBOX] = ComposeMsgBox("Uno o más campos son requeridos para completar el registro.", "error", GlobalConstants.MSGBOX_DELAY_MILISECS);
                return View();
            }

            // OK, form data is valid, now let's save it to database.
            try {
                ProductInfo info = Mapper.Map<ProductViewModel, ProductInfo>(m);
                _productService.Save(info);
                ViewData[ViewConstants.VIEWDATA_MSGBOX] = ComposeMsgBox("Product Successfully created.", "success", GlobalConstants.MSGBOX_DELAY_MILISECS);
            }
            catch (Exception) {
                ViewData[ViewConstants.VIEWDATA_MSGBOX] = ComposeMsgBox("Product not Successfully created.", "error", GlobalConstants.MSGBOX_DELAY_MILISECS);
            }
            //ProductViewModel p = new ProductViewModel();
           // return View(p);
            return RedirectToAction("Create");
        }

        /// <summary>
        /// Action to Edit a product record.
        /// </summary>
        /// <param name="id">The primary key to use.</param>
        /// <returns>View with record information to show</returns>
        public ActionResult Edit(int id) {
            ViewData[ViewConstants.VIEWDATA_YESNOVALUELIST] = _yesNoValueService.GetAll();
            ProductInfo info = _productService.Get(id);
            SetupMappers();
            ProductViewModel p = Mapper.Map<ProductInfo, ProductViewModel>(info);
            return View(p);
        }

        /// <summary>
        /// Action to submit contents to be stored in database.
        /// </summary>
        /// <param name="id">The primary key to use.</param>
        /// <param name="m">Information to save</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Edit(ProductViewModel m) {
            ProductViewModel p = null;
            ViewData[ViewConstants.VIEWDATA_YESNOVALUELIST] = _yesNoValueService.GetAll();
            ViewData[ViewConstants.VIEWDATA_MSGBOX] = "";
            if (!ModelState.IsValid) {
                ViewData[ViewConstants.VIEWDATA_MSGBOX] = ComposeMsgBox("Uno o más campos son requeridos para completar el registro.", "error", GlobalConstants.MSGBOX_DELAY_MILISECS);
                return View();
            }

            // OK, form data is valid, now let's save it to database.
            try {
                ProductInfo info = Mapper.Map<ProductViewModel, ProductInfo>(m);
                _productService.Update(info);
                ViewData[ViewConstants.VIEWDATA_MSGBOX] = ComposeMsgBox("Product Successfully edited.", "success", GlobalConstants.MSGBOX_DELAY_MILISECS);

                // Reload record to view again its data updated.
                info = _productService.Get(m.ProductId);
                SetupMappers();
                p = Mapper.Map<ProductInfo, ProductViewModel>(info);
            }
            catch (Exception e) {
                ViewData[ViewConstants.VIEWDATA_MSGBOX] = ComposeMsgBox("Product not Successfully edited." + e.Message, "error", GlobalConstants.MSGBOX_DELAY_MILISECS);
            }
            return View(p);
        }

        /// <summary>
        /// Injected by IoC. Access to Product Services.
        /// </summary>
        public IProductDataService ProductService {
            set { _productService = value; }
        }

        /// <summary>
        /// Injected by IoC. Access to YesNo Services.
        /// </summary>
        public IYesNoValueService YesNoValueService {
            set { _yesNoValueService = value; }
        }

        /// <summary>
        /// Injected by IoC. Access to ProductFilterCriteria Services.
        /// </summary>
        public IProductFilterCriteriaService ProductFilterCriteriaService {
            set { _productFilterCriteriaService = value; }
        }

        /// <summary>
        /// Injdected by IoC. Access PageSize services.
        /// </summary>
        public IPageSizeValueService PageSizeValueService {
            set { _pageSizeValueService = value; }
        }
    }
}
