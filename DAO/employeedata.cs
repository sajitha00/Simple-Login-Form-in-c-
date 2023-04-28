using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class employeedata
    {
        public bool saveemp(string name,string email)
        {
			bool result;
			try
			{
				using (var db = new try2Entities())
				{
					var employee = new empdata()
					{
						Name = name,
						Email = email,
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
