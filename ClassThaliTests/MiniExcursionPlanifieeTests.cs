using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassThali;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassThali.Tests
{
    [TestClass()]
    public class MiniExcursionPlanifieeTests
    {
        

      

        [TestMethod()]
        public void SetNombreInscritsTest()
        {
            MiniExcursion me = new MiniExcursion(1, "abc", 20);
            MiniExcursionPlanifiee mep = new MiniExcursionPlanifiee("1", me, DateTime.Parse("12:00"));

            Assert.AreEqual(0, mep.GetNombreInscrits(), "20");

            mep.SetNombreInscrits(20);
            Assert.AreEqual(20, mep.GetNombreInscrits(), "20");


        }

        [TestMethod()]
        public void EstCompleteTest()
        {
            MiniExcursion me = new MiniExcursion(1, "abc", 20);
            MiniExcursionPlanifiee mep = new MiniExcursionPlanifiee("1", me, DateTime.Parse("12:00"));

            Assert.AreEqual(false, mep.EstComplete(), "");

            mep.SetNombreInscrits(20);

            Assert.AreEqual(true, mep.EstComplete(), "");




        }

        [TestMethod()]
        public void HeureRetourPrevueTest()
        {
            MiniExcursion me = new MiniExcursion(1, "abc", 20);
            MiniExcursionPlanifiee mep = new MiniExcursionPlanifiee("1", me, DateTime.Parse("12:00"));

            Assert.AreEqual(DateTime.Parse("12:00"), mep.HeureRetourPrevue(), "aucune étapes enregistrées donc temps de départ reste le même");

            me.AjouteEtape("abc", 20);
            me.AjouteEtape("peterbot", 40);
            me.AjouteEtape("c", 81);


            Assert.AreEqual(DateTime.Parse("14:21"), mep.HeureRetourPrevue(), "ajout du temps des étapes sur l'heure de départ");


        }
    }
}