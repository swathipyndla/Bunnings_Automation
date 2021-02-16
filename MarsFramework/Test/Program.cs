using MarsFramework.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class Tenant : Global.Base
        {

            [Test]
            public void Validate_search_icon_is_clickable()
            {
                test = extent.StartTest("clcking on search icon");
                Validate_search_icon__is_clickable sicon = new Validate_search_icon__is_clickable();
                sicon.validate_search_icon();
            }

            [Test]
            public void Empty_Search()
            {
                test = extent.StartTest("clcking on search icon");
                Empty_search sicon = new Empty_search();
                sicon.Null_search();
            }


            [Test]
            public void Clear_search()
            {
                test = extent.StartTest("clcking on search icon");
                Clear_search sicon = new Clear_search();
                sicon.Clear();
            }

        }
    }
}