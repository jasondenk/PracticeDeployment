using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DeploymentPractice.Models
{
    public class DeploymentPracticeContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public DeploymentPracticeContext() : base("name=DeploymentPracticeContext")
        {
        }

        public System.Data.Entity.DbSet<DeploymentPractice.Models.DataExample> DataExamples { get; set; }
    }
}
