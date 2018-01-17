using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkOracle
{
    class Program
    {
        static void Main(string[] args)
        {
            using (OracleEntities oracleContexte = new OracleEntities())
            {
                //Console.WriteLine("---------------------------------------------------------------\n Cours et Séminaires ----------\n---------------------------------------------------------------");
                //var idEmploye = 33;
                //var requeteEmployesByid = from EMPLOYE in oracleContexte.EMPLOYEs where EMPLOYE.NUMEMP == idEmploye select EMPLOYE;

                //var employeId = requeteEmployesByid.FirstOrDefault();
                //if (employeId != null)
                //{
                //    Console.WriteLine(employeId.NOMEMP + " - " + employeId.PRENOMEMP + " - " + employeId.SALAIRE);
                //}
                //else
                //{
                //    Console.WriteLine("L'employé numéro " + idEmploye + " n'existe pas");
                //}


                //var requete = from c in oracleContexte.COURS join SEMINAIRE in oracleContexte.SEMINAIREs on c.CODECOURS equals SEMINAIRE.CODECOURS select c;
                //var lesCours = requete.Distinct().ToList();
                //foreach (var leCour in lesCours)
                //{
                //    Console.WriteLine(leCour.CODECOURS + " - " + leCour.LIBELLECOURS + " - " + leCour.NBJOURS);
                //    foreach (var lesemi in leCour.SEMINAIREs)
                //    {
                //        Console.WriteLine("      " + lesemi.DATEDEBUTSEM);
                //    }
                //}


                //var employeProjetNom = from emp in oracleContexte.EMPLOYEs
                //                       join prj in oracleContexte.PROJETs on emp.CODEPROJET equals prj.CODEPROJET
                //                       group emp by new { prj.CODEPROJET, prj.NOMPROJET } into groupeEmployes
                //                       select new
                //                       {
                //                           Code = groupeEmployes.Key.CODEPROJET,
                //                           Nom = groupeEmployes.Key.NOMPROJET,
                //                           Nombre = groupeEmployes.Count()
                //                       };
                //foreach (var ligne in employeProjetNom.ToList())
                //{
                //    Console.WriteLine(ligne.Code + " - " + ligne.Nom + " - " + ligne.Nombre);
                //}


                //var emp = oracleContexte.EMPLOYEs.Find(200);
                //if (emp == null)
                //{
                //    Console.WriteLine("L'employé 200 n'existe pas");
                //}
                //else
                //{
                //    emp.SALAIRE = emp.SALAIRE * (decimal)1.1;
                //    Console.WriteLine("le nouveau salaire = " + emp.SALAIRE);
                //    oracleContexte.SaveChanges();
                //}


                //COUR unCour = new COUR();
                //unCour.CODECOURS = "BR099";
                //unCour.LIBELLECOURS = "Entity Framework 6 avec Oracle";
                //unCour.NBJOURS = 4;
                //oracleContexte.COURS.Add(unCour);
                //oracleContexte.SaveChanges();
                //Console.WriteLine("Le cours a été créé");
            }


            using(OracleEntitiesMaison oracleContexte = new OracleEntitiesMaison())
            {
                Console.WriteLine("---------------------------------------------------------------\n Test de ToString() ----------\n---------------------------------------------------------------");
                //var requete = from c in oracleContexte.COURS join SEMINAIRE in oracleContexte.SEMINAIREs on c.CODECOURS equals SEMINAIRE.CODECOURS select c;
                //var lesCours = requete.Distinct().ToList();
                //foreach (var leCour in lesCours)
                //{
                //    Console.WriteLine(leCour.CODECOURS + " - " + leCour.LIBELLECOURS + " - " + leCour.NBJOURS);
                //    foreach (var lesemi in leCour.SEMINAIREs)
                //    {
                //        Console.WriteLine("      " + lesemi.DATEDEBUTSEM);
                //    }
                //}
                var requete = from s in oracleContexte.COURS select s;
                var lesCours = requete.ToList();
                foreach (var unCour in lesCours)
                {
                    Console.WriteLine(unCour);
                }

                var requeteEmp = from e in oracleContexte.EMPLOYEs select e;
                var lesEmployes = requeteEmp.ToList();
                Console.WriteLine("\n\n---------------------------------");
                foreach (var emp in lesEmployes)
                {
                    Console.WriteLine(emp);
                }
            }
            Console.ReadLine();
        }
    }
}
