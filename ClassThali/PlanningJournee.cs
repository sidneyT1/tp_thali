using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassThali
{
    public class PlanningJournee
    {
        // attributs privés
        private DateTime date;
        private List<MiniExcursionPlanifiee> lesMiniExcursionsPlanifiees;

        /// <summary>
        /// Constructeur de la classe PlanningJournee
        /// </summary>
        /// <param name="uneDate">date du planning</param>
        public PlanningJournee(DateTime uneDate)
        {
            this.date = uneDate;
            this.lesMiniExcursionsPlanifiees = new List<MiniExcursionPlanifiee>();
        }
         
       public double CalculerRecette()
       {
            double somme = 0;
            
            foreach(MiniExcursionPlanifiee MEP in this.lesMiniExcursionsPlanifiees) 
            {
                double montantParticipation = MEP.GetLaMe().GetMontantParticipation();
                somme += montantParticipation * MEP.GetNombreInscrits();
               
            }
            return somme;

            


       }

        public void AjouterMiniExcursionPlanifiee(MiniExcursionPlanifiee mep)
        {
            this.lesMiniExcursionsPlanifiees.Add(mep);
        }
    } 
}
