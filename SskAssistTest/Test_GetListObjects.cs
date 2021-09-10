using NUnit.Framework;
using SskAssistWF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SskAssistTest
{
    class Test_GetListObjects
    {
        [Test]
        public void Test_GetListObjects_CompareName()
        {
            string[] conf = new string[]
            {
                "shapeId=\"sst_msk_hdm_HM_hdmNode_HM_CurrentServer11_app_AuditEAR\" appName=\"AuditEAR\"",
                "shapeId=\"sst_msk_hdm_HM_hdmNode_HM_CurrentServer11_app_HdmEAR\"   appName=\"HdmEAR\"",
                "shapeId=\"sst_msk_hdm_HM_hdmNode_HM_CurrentServer11_app_AuditEAR\" appName=\"Audit\""
            };
            
            Assert.AreEqual(3, Parse.GetListObjects(conf, " appName=", "CurrentServer").Count);
        }

        [Test]
        public void Test_GetListObjects_CountNumber()
        {
            string[] conf = new string[]
            {
                "shapeId=\"sst_msk_hdm_HM_hdmNode_HM_CurrentServer11_app_AuditEAR\" appName=\"application\"",
                "shapeId=\"sst_msk_hdm_HM_hdmNode_HM_CurrentServer11_app_HdmEAR\"   appName=\"application1\"",
                "shapeId=\"sst_msk_hdm_HM_hdmNode_HM_CurrentServer11_app_AuditEAR\" appName=\"application2\""
            };

            Assert.AreEqual(3, Parse.GetListObjects(conf, " appName=", "CurrentServer").Count);
        }
    }
}