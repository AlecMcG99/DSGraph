using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using org.mariuszgromada.math.mxparser;


namespace WindowsFormsApp1
{
    class Func
    {
        private Function F;
        private Boolean showTraj;
        private int[] InitialCondition;

        public Func(String n, String f, Boolean t = false)
        {
            F = new Function(n, formatFunc(f), "x", "y");
            showTraj = t;
            InitialCondition = new int[1] { 1 };
        }

        public String getName()
        {
            return F.getFunctionName();
        }


        public String getFunction()
        {
            return F.getFunctionExpressionString();
        }

        public void addICs(int IC)
        {
            int[] temp = new int[InitialCondition.Length+1];
            temp[temp.Length -1] = IC;

        }
        public void addICs(int[] ICs)
        {
            InitialCondition = ICs;
        }

        public void setTraj(Boolean b)
        {
            showTraj = b;
        }

        public double calc()
        {
            return F.calculate();
        }
        /*
        ############################ Helper Functions #################################
        */

        private String formatFunc(String func)
        {

            if (func.Contains('x') && !func.Contains('y'))
            {
                func += " + 0*y";
            }
            else if (!func.Contains('x') && func.Contains('y'))
            {
                func += " + 0*x";
            }
            return func;
        }
    }
}
