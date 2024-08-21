using System.Xml.Linq;
using System.Text.RegularExpressions;
namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Extention method 
            /*    int x = 12345;
                *//*    int y = IntExtention.Reverse(x);
                    Console.WriteLine(y);*//*
                int y = x.Reverse();
                Console.WriteLine(y); */
            #endregion

            #region Var - dynamic 
            /*        var x = 12;
                    //    x = "dd"; // invalid 

                    dynamic y = 12;
                    y = "mirna";
                    y = 2.45; */


            #endregion

            #region Anonymous method 

            /*      var emp = new { Id = 1, name = "mirna"  , salary = 12}; 
                  Console.WriteLine(emp.name);
                  //emp.name = "mmm"; //invalid 
                  var emp02 = emp with { salary = 3000 }; 
                  Console.WriteLine(emp02.GetType().Name);*/
            #endregion

            #region linq 
            // linq ==> lanaguage intgrated query
            // LINQ +40 extemtion method
            // Extention Method For All collection that Implement interface "IEnumerable" 
            // named as LINQ opeartors  exited at class  Enumerable
            // Catogarized into 13 catorgey 
            /*      List<int> Number = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                  List<int> Oddnumber = Number.Where(Num=> Num % 2 == 1).ToList();
                  foreach (int num in Oddnumber)
                  {
                      Console.WriteLine(num);
                  }*/

            // you can use LINQ opeartor against data { data stored in sequense } 
            // regadless data stored [ Mysql , oracle  , sql server ] 

            //sequense => Object from class that implement built in interface IEnumerable
            //1- local  - static[L2object]  - Xml file [l2Xml] 
            //2-remote - l2EF
            #endregion

            #region syntax  fluent syntax 
            //fluent syntax
            /*      
                      List<int> Number = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };       
                      // 1.  calling LINQ as static method 
                      var Oddnumber = Enumerable.Where(Number , Num => Num % 2 == 1);
                      foreach (int num in Oddnumber)
                      {
                          Console.Write($"{num} ");
                      }
                      // 2.  calling LINQ as Opeartor " as extention method " [recommanded ] 
                      Oddnumber = Number.Where(Num => Num % 2 == 1);
          */
            #endregion
            #region Query syntax like sql server 
            //3.select *
            //1.from number n
            //2.where n %2==1
            //  List<int> Number = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /*
                        var oddnumber = from n in Number
                                        where n %2==1 
                                        select n;               // order by extention 
                                                                // must be begin wwith keyword "From" 
                                                                // must be end with " select , Group by " 
                        foreach (var n in oddnumber)
                        {
                            Console.WriteLine(n);
                        }*/
            #endregion
            #region Excution 

            #region Excetion - deferred excetion [ latest version of data ] 
            /*   List<int> Number = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
               var Oddnumber = Number.Where(Num => Num % 2 == 1);
               Number.AddRange(new int[] { 11, 12, 13, 14, 15});
               foreach (var n in Oddnumber )
               {
                   Console.WriteLine(n);
               }*/


            #endregion
            #region excution - Immadiate exc [ casting - element opertor - aggreagtion ] 
            /*     List<int> Number = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                 var Oddnumber = Number.Where(Num => Num % 2 == 1).ToList();  //when use to list the excution be immadiate 
                 Number.AddRange(new int[] { 11, 12, 13, 14, 15 });
                 foreach (var n in Oddnumber)
                 {
                     Console.WriteLine(n);
                 }*/
            #endregion
            #endregion

            #region DATA SETup

            /*            Console.WriteLine(ListGenrator.productlist[0]);
                        Console.WriteLine(ListGenrator.customerslist[0]);
            */

            #endregion
            // Deferred Execution  => postpone execution  
            // 1.  frist catogary : filter - where 
            // 2. transformation [projection] operator [select - select many]
            // 3. Ording Operators [Ascending , Descending , Reverse , ThenBy , ThenByDescending]
            #region filter - where 
            #region Get element Out of stock 
            /*    //fluent
                var result = ListGenrator.Productlist.Where(p => p.UnitsInStock == 0);

                //query 
                result = from p in ListGenrator.Productlist
                         where p.UnitsInStock == 0
                         select p;
                foreach (var unit in result)
                {
                    Console.WriteLine(unit);
                }*/
            #endregion

            #region get element in stock and category of meat / poultry 

            /*      // fluent syntax

                  var result = ListGenrator.Productlist.Where(p => p.UnitsInStock>0 && p.Category == "Meat/Poultry");

                  //query syntax

                  result = from p in ListGenrator.Productlist
                           where p.UnitsInStock > 0 && p.Category == "Meat/Poultry"
                           select p; 

                  foreach (var unit in result)
                  {
                      Console.WriteLine(unit);
                  }*/
            #endregion

            #region where indexed

            //indexed where 
            //valid with fluent only can't with query 
            /*     var result=  ListGenrator.Productlist.Where((p, i) => i < 10 && p.UnitsInStock == 0);


                   foreach (var unit in result)
                   {
                       Console.WriteLine(unit);
                   }*/
            #endregion
            #endregion

            #region // transformation [projection] operator [select - select many]

            #region // select productName from product
            /*   // fluent syntax 

               var result = ListGenrator.Productlist.Select(p => p.ProductName);
               // query syntax 

               result = from p in ListGenrator.Productlist
                        select p.ProductName; */
            #endregion

            #region select CustomerName from Customer

            /*      
                 // fluent 
                  var result = ListGenrator.Customerslist.Select(c => c.CustomerName);
                    //query 
                    result = from c in ListGenrator.Customerslist
                             select c.CustomerName;  */
            #endregion

            #region select order from customer
            //fluent 
            //      var result = ListGenrator.Customerslist.SelectMany(c => c.Orders);
            // query 
            /*        result = from c in  ListGenrator.Customerslist
                             from o in c.Orders
                             select o;*/
            #endregion

            #region select id and product name 
            /*       var result = ListGenrator.Productlist.Select(p => new {  p.ProductID,  p.ProductName });

                   var RESULT01 = from p in ListGenrator.Productlist
                                   select new
                                   {
                                       ProductID = p.ProductID,
                                       ProductName = p.ProductName
                                   }; */
            #endregion

            #region select product In stock and applu discount 10% on its price 

            //fluent 

            /*      var result = ListGenrator.Productlist.Where(p => p.UnitsInStock > 0)
                      .Select(p => new
                      {
                          id = p.ProductID,
                          name = p.ProductName,
                          oldprice = p.UnitPrice,
                          newprice = p.UnitPrice - (p.UnitPrice * 0.1M),
                      });


                  //query 
                  result = from p in ListGenrator.Productlist
                           where p.UnitsInStock > 0
                           select new
                           {
                               id = p.ProductID,
                               name = p.ProductName,
                               oldprice = p.UnitPrice,
                               newprice = p.UnitPrice - (p.UnitPrice * 0.1M),
                           }; */
            #endregion

            #region indexer select 
            // indexer vaild with fluent only can't do it with query 
            /*      var result = ListGenrator.Productlist.Where(p => p.UnitsInStock > 0).Select((P, I) => new
                  {
                     idex=I,
                     Name = P.ProductName,
                  });
                  foreach (var unit in result)
                  {
                      Console.WriteLine(unit);
                  }*/

            #endregion

            #endregion

            #region Ording Operators [Ascending , Descending , Reverse , ThenBy , ThenByDescending]
            #region Get Products Ordered By Price Asc
            //fluent 
            /*   var result = ListGenrator.Productlist.OrderBy(p => p.UnitPrice); //Ascending
               //query 
               result = from p in ListGenrator.Productlist
                        orderby p.UnitPrice 
                        select p;*/


            #endregion
            #region Get Products Ordered By Price Desc
            /*   var  result = ListGenrator.Productlist.OrderByDescending(p => p.UnitPrice); // Descending
                 result = from p in ListGenrator.Productlist
                          orderby p.UnitPrice descending
                          select p;*/

            #endregion
            #region Get Products Ordered By Price Asc and Number Of Items In Stock
            /*       var result = ListGenrator.Productlist.OrderBy(p=>p.UnitPrice).ThenByDescending(p=>p.UnitsInStock).Reverse();

                   #endregion
                   foreach (var item in result)
                   {
                       Console.WriteLine(item);
                   }*/
            #endregion

            #region   Elements Operator -Immediate Execution[Valid Only With Fluent Syntax]


            /*   var result = ListGenrator.Productlist.First(); // get frist element 
                result = ListGenrator.Productlist.Last(); // get last element 

               Console.WriteLine(result?.ProductName ?? "not found ");*/
            // first and last may be throw exception -> will exception if sequence is empty 

            /*     var result = ListGenrator.Productlist.FirstOrDefault(); // get frist element or default =>null 

                 result = ListGenrator.Productlist.LastOrDefault(); // get last element  or default =>null 

                 Console.WriteLine(result?.ProductName ?? "not found ");
     */
            /*   var result = ListGenrator.Productlist.First(p => p.UnitsInStock == 0); //return first element match condition 
                result = ListGenrator.Productlist.Last(p => p.UnitsInStock == 0); //return Last element*/


            #endregion

            #endregion

            #region Aggregate Operators  - Immediate Execution

            #region Count
            // count();
            // var result = ListGenrator.Productlist.Count(p => p.UnitsInStock == 0); // return count off element match condition 
            //    result = ListGenrator.Productlist.Count; // return no. of element   
            #endregion
            #region Max
            //var result = ListGenrator.Productlist.Max(); // mut implelemt icompareable 
            /*         var Minlength = ListGenrator.Productlist.Min(p=>p.ProductName.Length); //  if max have a condition you don't need to use icompareable 

                     var result = (from p in ListGenrator.Productlist
                                  where p.ProductName.Length == Minlength
                                  select p).FirstOrDefault();*/


            /*   string[] names = { "aya", "Osama", "Amr", "Mohammed" }; 
               var result = names.Aggregate((str1,str2)=>$"{str1}{str2}");
               Console.WriteLine(result);*/
            #endregion
            #region casting 

            #endregion

            #endregion

            #region Genration operation    - Deferred Execution
            /*     //valid with only fluent syntax 
                 // call  with static method  from class Enumrable 
                 Enumerable.Range(0, 100); // 0 : 99 
                 Enumerable.Repeat(2, 100); // repeat 2 for 100 time 
                 Enumerable.Empty<int>();*/

            #endregion

            #region Set Operators [Union Family] - Deferred Execution
            // work between seq and must same datatype 
            /*            var sed01 = Enumerable.Range(0, 100); // 0..99
                        var sed02 = Enumerable.Range(50, 100); // 50..149
                        var result = sed01.Union(sed02); // union all with out duplication 
                        var result2 = sed01.Concat(sed02); // union all 
                        result2 = result2.Distinct(); //Remove Duplicates [Concat + Distinct => Act as Union]
                        var result3 = sed01.Intersect(sed02);//Return Elements in 1st Sequence and Exist in 2nd Sequence 
                        var result4 = sed01.Except(sed02);// Return Elements in 1st Sequence and Not Exist in 2nd Sequence

                        Console.WriteLine("\n ======================union=============================");

                        foreach (var sed in result)
                        {
                            Console.Write($"{sed}  ");
                        }
                        Console.WriteLine("\n ======================conacat =============================");
                        foreach (var sed in result2)
                        {
                            Console.Write($"{sed}  ");
                        }
                        Console.WriteLine("\n ======================intersect =============================");
                        foreach (var sed in result3)
                        {
                            Console.Write($"{sed}  ");
                        }
                        Console.WriteLine("\n ======================except =============================");
                        foreach (var sed in result4)
                        {
                            Console.Write($"{sed}  ");
                        }
            */

            #endregion

            #region Quantifier Operator - Return boolean
            /*    var result = ListGenrator.Productlist.Any();//If Sequence contains at least one Element Will Return True
                result = ListGenrator.Productlist.Any(p => p.UnitsInStock == 0);//If Sequence contains at least one Element match condition  => True
                result = ListGenrator.Productlist.All(p => p.UnitsInStock == 0);// => If All Elements in Sequence Match Condition Will Return True
                Console.WriteLine(result);
                var sed01 = Enumerable.Range(0, 100); // 0..99
                var sed02 = Enumerable.Range(50, 100); // 50..149
                var result1 = sed01.SequenceEqual(sed02);*/



            #endregion

            #region Zipping Operator - ZIP
            //ZIP => Produces a sequence with elements from the Two Or Three specific sequences

            /*        string[] name = { "aya", "moh", "ahmed", "osama" };
                    int[] number = Enumerable.Range(1, 10).ToArray();
                    char[] chars = { 'A', 'b', 'c', 'e' };
                    var result = name.Zip(number);
                    var result1 = name.Zip(number, (name, number) => new { index = number, name });
                    var result2 = name.Zip(number, chars);
                  foreach ( var item in result)
                        Console.WriteLine(item);
                  Console.WriteLine("-----------------------------------------------");
                    foreach (var item in result1)
                        Console.WriteLine(item);
                    Console.WriteLine("-----------------------------------------------");

                    foreach (var item in result2)
                        Console.WriteLine(item);
        */


            #endregion
            #region Grouping Operators
            #region Get Products Grouped by Category
            /*    //query syntax 
                var result = from p in ListGenrator.Productlist
                             group p by p.Category;*/
            //var result = ListGenrator.Productlist.GroupBy(p => p.Category);

            #endregion

            #region Get Products in Stock Grouped by Category That Contains More Than 10 Product
            /*          var result = from p in ListGenrator.Productlist
                                   where p.UnitsInStock > 0
                                   group p by p.Category
                                   into category
                                   where category.Count() > 10
                                   select category;
                      foreach (var category in result)
                      {
                          Console.WriteLine(category.Key);
                          foreach (var product in category)
                          {
                              Console.WriteLine($"                         {product.ProductName}");
                          }
                      }*/

            #endregion
            #region Get Category Name of Products in Stock That Contains More Than 10 Product and Number of Product In Each Category

            /*
                var result = from p in ListGenrator.Productlist
                             where p.UnitsInStock > 0
                             group p by p.Category
                            into category
                             where category.Count() > 10
                             select new
                             {
                                 category = category.Key,
                                 count = category.Count()
                             };

                result = ListGenrator.Productlist.Where(p => p.UnitsInStock > 0)
                                                 .GroupBy(p => p.Category)
                                                 .Where(p => p.Count() > 10)
                                                 .Select( x=> new
                                                 {
                                                     category = x.Key,
                                                     count = x.Count()
                                                 });
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
    */
            #endregion

            #endregion
            #region Partitioning Operators
            /*       var result = ListGenrator.Productlist.Take(10); // retur frist 10 elemet 
                   result = ListGenrator.Productlist.Where(p => p.UnitsInStock > 0).Take(5); // retur frist 5 elemet in stock
                   result = ListGenrator.Productlist.TakeLast(10); // retur last 10 elemet 
                   result = ListGenrator.Productlist.Skip(5); // skip frist 5 elemet and start from 6 
                   int[] numbers = { 5, 4, 1, 3, 9, 8, 2 };
                   //var result = number.TakeWhile((num, i) => num > i); // stop after get false 
                   var result = numbers.SkipWhile(num => num % 3 != 0); //return after get false 
                   foreach (var num in numbers)
                   {
                       Console.WriteLine(num);
                   }*/







            #endregion

            #region let-  into 
            //valid only with query syntax 
      /*      List<string> Name = new List<string> { "omar ", "ali", "sally ", "mohammed", "ahmed" };



            var result = from n in Name
                         select Regex.Replace(n, "[AOUIEaouie]", string.Empty)
                         into newvalue
                         where newvalue.Length > 3
                         select newvalue;
            // use into 

             result = from n in Name
                         let newvalue = Regex.Replace(n, "[AOUIEaouie]", string.Empty)
                         where newvalue.Length > 3
                         select newvalue*/;





            #endregion
        }
    }
}
