using Microsoft.Ajax.Utilities;
using NLDTlession06.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NLDTlession06.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member/create one
        public ActionResult CreateOne()
        {
            return View();
        }
        // GET: Member/create one
        [HttpPost]
        public ActionResult CreateOne(NLDTmember m) 
        {
            // chuyen du lieu nhan dc toi view
            return View("Details", m);
        }
        // GET: Member/create two
        public ActionResult CreateTwo() 
        {
            return View();
        }
        // GET: Member/create two
        [HttpPost]
        public ActionResult CreateTwo(NLDTmember m)
        {
            // ktra trong cac truong va thong bao toi view
            if (m.id == null)
            {
                ViewBag.error = " hay nhap ma so ";
                return View();
            }
            if (m.username == null)
            {
                ViewBag.error = " hay nhap ten dang nhap  ";
                return View();
            }
            if (m.fullname == null)
            {
                ViewBag.error = " hay nhap ten ho va ten  ";
                return View();
            }
            if (m.age == null)
            {
                ViewBag.error = " hay nhap tuoi ";
                return View();
            }
            if (m.email == null)
            {
                ViewBag.error = " hay nhap email ";
                return View();
            }
            //mau ktra email
            string regexPattern=@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}}";
            if 
                (!System.Text.RegularExpressions.Regex.IsMatch(m.email,regexPattern))
            {
                ViewBag.error = " hay nhap dung dinh dang";
                    return View();
            }
            // neu k say ra loi thi chuyen du lieu toi view details
            return View("Details",m);
        }
        // get / member/three
        public ActionResult  CreateThree()
        { return View(); }
        // get / member/three
        [HttpPost]
        public ActionResult CreateThree(NLDTmember m)
        {
            // neu trang thai du lieu cua model hop le thi chuyen du lieu toi view details
            if(ModelState.IsValid)
                return View("Details",m);
            else
            { return View(); } //qlai view three de bao loi
        }
        public ActionResult Details()
        {
                return View();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}