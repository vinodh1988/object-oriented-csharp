using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ObjectOriented.InheritanceSet
{
    internal class SealedGroup
    {
        public virtual void Info() {
            Console.WriteLine("Info method");
        }
    }

    internal sealed class NewOne : SealedGroup
    {
        readonly string data = "Name it"; //constant data member
        public sealed override void Info()
        {
            const int a = 20;
           
            Console.WriteLine("Info method NewOne");
        }
    } //it cannot be inherited further

    /*internal class NewerOne : NewOne {
       public override void Info() { 
        
        } cannot be overriden anymore
    }class cannot be inherited as it is inherited */
} 

