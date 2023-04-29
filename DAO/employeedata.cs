using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAO
{
    public class employeedata
    {
        public bool saveemp(employee_model model)
        {
			 bool result;
			try
			{
				using (var db = new try2Entities())
				{
					var employee = new empdata()
					{
						Name = model.Name,
						Email = model.Email,
						CreateDate = DateTime.Now,
					};
					db.empdatas.Add(employee);
					db.SaveChanges();
					result	= true;

				}

			}
			catch (Exception ex)
			{

				throw ex;
			}
			return result;
        }
    }
}
