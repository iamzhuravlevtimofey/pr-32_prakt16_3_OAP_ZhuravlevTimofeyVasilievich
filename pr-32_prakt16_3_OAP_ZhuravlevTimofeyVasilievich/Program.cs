using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace pr_32_prakt16_3_OAP_ZhuravlevTimofeyVasilievich
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Department> department = new List<Department>()
             {
                 new Department { Name = "Отдел закупок", Reg ="Германия" },
                 new Department { Name = "Отдел продаж", Reg ="Испания"},
                 new Department { Name = "Отдел маркетинга", Reg ="Испания" }
             };
             List<Employ> employes = new List<Employ>()
             {
                 new Employ {Name="Иванов", Department ="Отдел закупок"},
                 new Employ {Name="Петров", Department ="Отдел закупок"},
                 new Employ {Name="Сидоров", Department ="Отдел продаж"},
                 new Employ {Name="Лямин", Department ="Отдел продаж"},
                 new Employ {Name="Сидоренко", Department ="Отдел маркетинга"},
                 new Employ {Name="Кривоносов", Department ="Отдел продаж"}
             };

             var result = from pl in employes
                          join t in department on pl.Department equals t.Name
                          select new { Name = pl.Name, Department = pl.Department, Reg = t.Reg };

             foreach (var item in result)
             {
                Console.WriteLine($"{item.Name} - {item.Department} ({item.Reg})");
             }
             Console.ReadKey();
        }
    }

     internal class Employ
      {
          public string Name { get; set; }
          public string Department { get; set; }
      }

      internal class Department
      {
          public string Name { get; set; }
          public string Reg { get; set; }
      }
}
