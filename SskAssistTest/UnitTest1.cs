using NUnit.Framework;
using SskAssistWF;
using System.Collections.Generic;

namespace SskAssistTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TrimPrefixAndDigitsTest_Prefix()
        {
            string actual = Parse.TrimPrefDig("lpar1_AccessServer");
            string expected = "AccessServer";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TrimPrefixAndDigitsTest_Digits()
        {
            string actual = Parse.TrimPrefDig("AccessServer1145");
            string expected = "AccessServer";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetConfigAddTest_CountApp()
        {
            
            Assert.AreEqual(10, Parse.GetConfigAdd(configProd, GetTestServersList()).Length);
        }

        string[] configProd = new string[]
        {
            "<!-- Application status  -->",
            "<parameter template=\"J2EEApplicationStatusParameterTemplateWasCosB\" shapeId=\"cos_B_cskNode11_B_AccessServer11_app_AccessServerCOSEAR\" appName=\"AccessServerCOSEAR\" pattern=\"WebSphere:*,name=AccessServerCOSEAR,j2eeType=J2EEApplication,node=B_cskNode11,type=J2EEApplication,Server=B_AccessServer11,cell=B_cosCell\" description=\"Состояние приложения AccessServerCOSEAR на сервере B_AccessServer11 на B_cskNode11 (ЦОС-ПСДК).\"/>",
            "<parameter template=\"J2EEApplicationStatusParameterTemplateWasCosB\" shapeId=\"cos_B_cskNode11_B_AccessServer11_app_LogReaderEAR\" appName=\"LogReaderEAR\" pattern=\"WebSphere:*,name=LogReaderEAR,j2eeType=J2EEApplication,node=B_cskNode11,type=J2EEApplication,Server=B_AccessServer11,cell=B_cosCell\" description=\"Состояние приложения LogReaderEAR на сервере B_AccessServer11 на B_cskNode11 (ЦОС-ПСДК).\"/>",
            "<parameter template=\"J2EEApplicationStatusParameterTemplateWasCosB\" shapeId=\"cos_B_cskNode11_B_AccessServer11_app_PSARSDispatcherEAR\" appName=\"PSARSDispatcherEAR\" pattern=\"WebSphere:*,name=PSARSDispatcherEAR,j2eeType=J2EEApplication,node=B_cskNode11,type=J2EEApplication,Server=B_AccessServer11,cell=B_cosCell\" description=\"Состояние приложения PSARSDispatcherEAR на сервере B_AccessServer11 на B_cskNode11 (ЦОС-ПСДК).\"/>",
            "<parameter template=\"J2EEApplicationStatusParameterTemplateWasCosB\" shapeId=\"cos_B_cskNode21_B_AccessServer21_app_LogReaderEAR\" appName=\"LogReaderEAR\" pattern=\"WebSphere:*,name=LogReaderEAR,j2eeType=J2EEApplication,node=B_cskNode21,type=J2EEApplication,Server=B_AccessServer21,cell=B_cosCell\" description=\"Состояние приложения LogReaderEAR на сервере B_AccessServer21 на B_cskNode21 (ЦОС-ПСДК).\"/>",
            "<parameter template=\"J2EEApplicationStatusParameterTemplateWasCosB\" shapeId=\"cos_B_cskNode21_B_AccessServer21_app_PSARSDispatcherEAR\" appName=\"PSARSDispatcherEAR\" pattern=\"WebSphere:*,name=PSARSDispatcherEAR,j2eeType=J2EEApplication,node=B_cskNode21,type=J2EEApplication,Server=B_AccessServer21,cell=B_cosCell\" description=\"Состояние приложения PSARSDispatcherEAR на сервере B_AccessServer21 на B_cskNode21 (ЦОС-ПСДК).\"/>",
            "<parameter template=\"J2EEApplicationStatusParameterTemplateWasCosB\" shapeId=\"cos_B_csoNode11_B_PsaumServer11_app_ManageContourEAR\" appName=\"ManageContourEAR\" pattern=\"WebSphere:*,name=ManageContourEAR,j2eeType=J2EEApplication,node=B_csoNode11,type=J2EEApplication,Server=B_PsaumServer11,cell=B_cosCell\" description=\"Состояние приложения ManageContourEAR на сервере B_PsaumServer11 на B_csoNode11 (ЦОС-ПСДК).\"/>",
            "<parameter template=\"J2EEApplicationStatusParameterTemplateWasCosB\" shapeId=\"cos_B_csoNode21_B_AspdServer_app_aspdWSServiceEAR\" appName=\"aspdWSServiceEAR\" pattern=\"WebSphere:*,name=aspdWSServiceEAR,j2eeType=J2EEApplication,node=B_csoNode21,type=J2EEApplication,Server=B_AspdServer,cell=B_cosCell\" description=\"Состояние приложения aspdWSServiceEAR на сервере B_AspdServer на B_csoNode21 (ЦОС-ПСДК).\"/>"

        };

        
        
        public SortedSet<Server> GetTestServersList()
        {
            SortedSet<Server> serversList = new SortedSet<Server>();

            Server accessServer = new Server("AccessServer");
            accessServer.Apps.Add("-----newTestApp-----");
            
            serversList.Add(accessServer);

            return serversList;
        }
    }
}