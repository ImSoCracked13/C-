namespace CourseraLab
{
    internal class Program 
    {
        public class Product {
            private string _Name;
            private double _Price;

        }

            // 1. Define the private instance variables here. The string _Name and the double _Price


            // 2. Define the public properties here. 
            
        public string Name {
            get {
                 return _Name;
                    //here you need to return the _Name between two square brackets [_Name];
                }
            set {
                 _Name = value;
                    //here you need to assign the value keyword to the _name instance variable
                }
            }

            

            
        public double Price {
            get {
                return _Price * 0.71;
                    //here you need to return the price in JOD. Meaning that you need to multiply the _Price with 0.71 and return it.
                }
            set {
                 _Price = value;
                    //here you need to set the value keyword to the _Price instance variable.
                }
            }

            

            //3. Define the custom constructor here

            /*
            here you need to create a custom constructor with two parameters. The first one for the name and the second one for the price.
            */

            public Product(string N, double P) {
                //assign N to the name instance variable
                N = _Name;
                //assign the P for the price instance variable
                P = _Price;
            }

            //4. Define the parameter-less constructor here that invokes the chaining constructor with Empty as a name and 0 as a price
            
            public Product() : this(...) {
            this._Name = "";
            this._Price = 0;
               
            }
            

            //5. Override the ToString here to return a string with this format: 
            //"[_Name] costs Price JOD"
            //Note that, if you implemented the Name and Price properties correctly, you just need to return $"{Name} costs {Price} JOD"
            public override string ToString()
            {
                return $"{_Name} costs {_Price} JOD";
            }

            //6. Override the Equals method
            
            public override bool Equals(Object obj){
                Product P = obj as Product;
                if(P == null){
                    return false;
                }
                //compare between this and P objects if they have the same _Name and _Price            

            }
            

            //7. Define the SalePrice method here

            public double SalePrice()
            {
                double Value = 0;
                //You can use nested if to implement this method.
                //For the first case, check if _Price is greater than or equals 200, if so return the sale price which is (1.0-0.25) of the _Price
                
                if(this._Price >= 200) {
                    Value = this._Price * 0.75;
                }
                else if(100 < this._Price < 200) { //the _Price between 100 and less than 200
                    Value = this._Price * 0.8;
                } 
                else { //others
                    Value = this._Price * 0.9;
                }

                


                return Value;
            }


            //8. Define the  PrintPriceNTimes here

            public string PrintPriceNTimes(int N)
            {
                string Result = "";
                for(int i=0; i<N;i++){
                //concatenates this._Price to the Result
                //concatenates , to the Result 
                }
                //remove the last comma.
                Result = Result.TrimEnd(',');

                return Result;
            }
        }
    }
