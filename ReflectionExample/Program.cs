using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee;
using System.Reflection;

namespace ReflectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assembly t = Assembly.GetAssembly(typeof(EmployeeClass));
            Type tt = typeof(EmployeeClass);
            ConstructorInfo[] ci = tt.GetConstructors();
            foreach(var r in ci)
            {
                Console.WriteLine("constructor names" + r.Name);
                Console.WriteLine("ispublic" + r.IsPublic);
                ParameterInfo[] pi = r.GetParameters();
                foreach(var p in pi)
                {
                    Console.WriteLine("parameters type" + p.ParameterType + "\nparameter position " + p.Position + "\n Default value for parameter" + p.DefaultValue);
                }
            }
            Console.WriteLine("********************#######***************************");
            MethodInfo[] mi = tt.GetMethods();
            foreach(var r in mi)
            {
                Console.WriteLine("method name:" + r.Name + "\n module:" + r.Module + "\n return type" + r.ReturnType + "\nis public" + r.IsPublic); 
            }
            Console.WriteLine("********************#######***************************");
            MemberInfo[] fi = tt.GetMembers();
            foreach(var f in fi)
            {
                Console.WriteLine();
                Console.WriteLine("Field name   :" + f.Name + "\nModule       :" + f.Module + "\nMember type  :" + f.MemberType + "\ndefault      :" + f.DeclaringType);
            }
            Console.WriteLine("********************#######***************************");
        }
    }
}
