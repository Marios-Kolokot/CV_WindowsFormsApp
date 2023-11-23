using CV_WindowsFormsApp.DataBaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Effort.Provider;
using Effort;
using CV_WindowsFormsApp.Models;
using CV_WindowsFormsApp.Interfaces;
using CV_WindowsFormsApp.Services;
//@inject CV_WindowsFormsApp.Interfaces.ICandidates _candidatesService
//@inject CV_WindowsFormsApp.Interfaces.IDegrees _degreesService



namespace CV_WindowsFormsApp
{
   
    public static class Program
    {
        
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //

            //IUnityContainer container = new UnityContainer();

            //container.RegisterInstance(new MyDbContext());

            //container.RegisterType(typeof(IRepository), typeof(Repository));

            //var repository = container.Resolve<IRepository>();

            //var entities = repository.GetAllCandidatesTest().ToList();

            //

            //using (var context1 = new MyDbContext())
            //{
            //    var myTemp1 = context1.Candidates.ToList();

            //    Console.WriteLine(myTemp1.Select(m => m.LastName).ToString());
            //}

            //using (var context2 = new MyDbContext())
            //{
            //    var myTemp2 = context2.Degrees.ToList();

            //    Console.WriteLine(myTemp2.Select(m => m.Name).ToString());
            //}

            MyDbContext context = new MyDbContext();

            var ListOfCandidates = context.Candidates.ToList();

            var ListOfDegrees=context.Degrees.ToList();


            

    
           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            
        }
    }
}
