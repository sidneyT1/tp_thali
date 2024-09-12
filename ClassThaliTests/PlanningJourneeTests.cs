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
    public class PlanningJourneeTests
    {
        [TestMethod()]
        public void CalculerRecetteTest()
        {
            MiniExcursion ME = new MiniExcursion(1, "Visite de l'ile au large de THALI", 20, 10);
            MiniExcursionPlanifiee mep = new MiniExcursionPlanifiee("1", ME, DateTime.Parse("12:00"));
            MiniExcursionPlanifiee mep1 = new MiniExcursionPlanifiee("1", ME, DateTime.Parse("12:00"));
            PlanningJournee pla = new PlanningJournee(DateTime.Parse("12:00"));
            
            
            pla.AjouterMiniExcursionPlanifiee(mep);
            pla.AjouterMiniExcursionPlanifiee(mep1);

           
            Assert.AreEqual(0, pla.CalculerRecette(), "pas de montant");

            mep.SetNombreInscrits(2);
            mep1.SetNombreInscrits(4);
           
            
            Assert.AreEqual(60, pla.CalculerRecette(), "aprèes set");


        }
    }
}