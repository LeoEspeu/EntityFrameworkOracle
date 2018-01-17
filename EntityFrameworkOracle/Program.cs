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
                Console.WriteLine("--------------------------");
                var idEmploye = 33;
                var requeteEmployesByid = from EMPLOYE in oracleContexte.EMPLOYEs where EMPLOYE.NUMEMP == idEmploye select EMPLOYE;

                var employeId = requeteEmployesByid.FirstOrDefault();
                if (employeId != null)
                {
                    Console.WriteLine(employeId.NOMEMP + " - " + employeId.PRENOMEMP + " - " + employeId.SALAIRE);
                }
                else
                {
                    Console.WriteLine("L'employé numéro " + idEmploye + " n'existe pas");
                }
            }
            Console.ReadLine();
        }
    }
}
