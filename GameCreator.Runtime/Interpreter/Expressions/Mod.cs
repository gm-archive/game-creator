﻿using System;
namespace GameCreator.Runtime.Interpreter
{
    class Mod : Expr
    {
        Expr expr1, expr2;
        public Mod(Expr e1, Expr e2, int l, int c) : base(l, c) { expr1 = e1; expr2 = e2; }
        public override Value Eval()
        {
            Value v1 = expr1.Eval(), v2 = expr2.Eval();
            if (!(v1.IsReal && v2.IsReal)) Error("Wrong type of arguments to mod.");
            return (double)((long)v1.Real % (long)v2.Real);
        }
    }
}