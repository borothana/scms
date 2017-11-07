﻿using SCMS.Datas;
using SCMS.Models;
using SCMS.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SCMS.UI.Controllers
{
    public class StoryApprovalController : Controller
    {
        ISCMS _repo = SCMSFactory.Create();
        // GET: StoryApproval
        [HttpGet]
        public ActionResult Index()
        {
            var model = _repo.GetStoryList();
            return View(model);
        }

        [HttpGet]
        public ActionResult ViewStory (int id)
        {
            Story model = _repo.GetStoryById(id);

            return View(model);
        }

        [HttpGet]
        public ActionResult Approve()
        {
            return View(new Story());
        }

        [HttpPost]
        public ActionResult Approve(StoryVM story)
        {
            //need to create property for aproval in repo 
            //story need to be approve and remove from pending list
            throw new Exception();
        }

        [HttpGet]
        public ActionResult Denied()
        {
            //need to create property for denial in repo
            //story will be denied and message will need to be included
            //story removed from pending list
            throw new Exception();
        }
    }
}