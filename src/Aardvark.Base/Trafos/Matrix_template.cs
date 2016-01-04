﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Aardvark.Base
{
    // AUTOGENERATED CODE - DO NOT CHANGE!

    //# Action comma = () => Out(", ");
    //# Action add = () => Out(" + ");
    //# Action xor = () => Out(" ^ ");
    //# Action andand = () => Out(" && ");
    //# Action addqcomma = () => Out(" + \",\" ");
    //# Action addbetweenM = () => Out(" + betweenM ");
    //# var tcharA = new[] { "i", "l", "f", "d" };
    //# var ftypeA = new[] { "int", "long", "float", "double" };
    //# var ctypeA = new[] { "double", "double", "float", "double" }; // computation types
    //# var fields = new[] {"X", "Y", "Z", "W"};
    //# var oper = new[] {"operator *", "Multiply"};
    //# var ops = new[] {" + ", " - ", " % ", " / ", " * "};
    //# var bops = new[] {"<", ">", "==", "<=", ">="};
    //# var opaction = new[,] {{"operator +", "operator -", "operator %", "operator /", "operator *"},{"Add", "Subtract", "Modulo", "Divide", "Multiply"}};
    //# for (int n = 2; n <= 4; n++) {
    //# for (int m = n; m <= (n+1) && m < 5; m++) { 
    //# for (int t = 0; t < tcharA.Length; t++) {
    //#     var msub1 = m - 1;
    //#     var tchar = tcharA[t];
    //#     var nm = n * m;
    //#     var nmtype = "M" + n + m + tchar;        // Matrix type
    //#     var mmtype = "M" + m + m + tchar;
    //#     var vmtype = "V"+ m + tchar;
    //#     var vmsub1type = "V"+ msub1 + tchar;
    //#     var vntype = "V"+ n + tchar;
    //#     var nfields = fields.Take(n).ToArray();
    //#     var mfields = fields.Take(m).ToArray();
    //#     var ftype = ftypeA[t];
    //#     var ctype = ctypeA[t];
    #region __nmtype__

    
    [StructLayout(LayoutKind.Sequential)]
    public partial struct __nmtype__ : IValidity, IMatrix<double>
    {
        //# n.ForEach(j => {
        public __ftype__ /*# m.ForEach(k => { */M__j____k__/*# }, comma); */;
        //# });

        #region Constructors

        public __nmtype__(/*# n.ForEach(r => { */
                /*# m.ForEach(s => {*/__ftype__ m__r____s__/*#}, comma);}, comma); */)
        {
            //# n.ForEach(r => {
            /*# m.ForEach(s => { */M__r____s__ = m__r____s__; /*# }); */
            //# });
        }

        public __nmtype__(__ftype__[] a)
        {
            //# int l = 0;
            //# n.ForEach(r => { m.ForEach(s => {
            M__r____s__ = a[__l__];
            //# l++; }); });
        }
        
        public __nmtype__(__ftype__[] a, int start)
        {
            //# l = 0;
            //# n.ForEach(r => { m.ForEach(s => {
            M__r____s__ = a[start + __l__];
            //# l++; }); });
        }

        #endregion

        #region Conversions

        //# for (int t1 = 0; t1 < tcharA.Length; t1++) { 
        //#     for (int a = 2; a <= 4; a++) {
        //#         for (int b = a; b <= (a+1) && b < 5; b++) {
        //#             var MabType1 = "M" + a + b + tcharA[t1];
        //#             if (n != a || m != b || t1 != t)  {
        public static explicit operator __nmtype__(__MabType1__ m)
        {
            return new __nmtype__ {
                //# n.ForEach(r => {
                /*# m.ForEach(s => { if (r >= a || s >= b) { if (r != s) {*/M__r____s__ = 0, /*#} else if ( r == s) {*/M__r____s__ = 1, /*#}} if((r < a) && ( s < b)) {*/M__r____s__ = /*# if (t != t1) {*/(__ftype__)/*#}*/m.M__r____s__, /*#} }); */
                //# });
            };
        }

        //#             }
        //#         }
        //#     }
        //# }
        //# for (int t1 = 0; t1 < tcharA.Length; t1++) {
        //#     var ftype1 = ftypeA[t1];
        public static explicit operator __nmtype__(__ftype1__[] a)
        {
            return new __nmtype__(/*# { int c = 0; n.ForEach(r => { */
                /*# m.ForEach(s => { if (t != t1) { */(__ftype__)/*# } */a[__c__]/*# ++c; }, comma); }, comma); } */);
        }

        public static explicit operator __nmtype__(__ftype1__[,] a)
        {
            return new __nmtype__ (/*# n.ForEach(r => { */
                /*# m.ForEach(s => { if (t != t1) { */(__ftype__)/*# } */a[__r__, __s__]/*# }, comma); }, comma); */);
        }

        public static explicit operator __ftype1__[](__nmtype__ m)
        {
            return new __ftype1__[] {/*# n.ForEach(r => { */
                /*# m.ForEach(s => { if (t != t1) { */(__ftype1__)/*# } */m.M__r____s__/*# }, comma); }, comma); */
            };
        }

        public static explicit operator __ftype1__[,](__nmtype__ m)
        {
            return new __ftype1__[,] {/*# n.ForEach(r => { */
                { /*# m.ForEach(s => { if (t != t1) { */(__ftype1__)/*# } */m.M__r____s__/*# }, comma); */ }/*# }, comma); */
            };
        }

        public void CopyTo(__ftype1__[] array, long index)
        {
            //# n.ForEach(j => { m.ForEach(k => { var jk = j * m + k;
            array[index + __jk__] = /*#  if (t != t1) { */(__ftype1__)/*# } */M__j____k__;
            //# });});
        }

        //# }
        //# for (int t1 = 0; t1 < tcharA.Length; t1++) {
        //#     var nmtype1 = "M" + n + m + tcharA[t1];
        //#     var ftype1 = ftypeA[t1];
        /// <summary>
        /// Returns a copy with all elements transformed by the supplied function.
        /// </summary>
        public __nmtype1__ Copy(Func<__ftype__, __ftype1__> element_fun)
        {
            return new __nmtype1__(/*# n.ForEach(r => { */
                /*# m.ForEach(s => { */element_fun(M__r____s__)/*# }, comma); }, comma); */);
        }

        /// <summary>
        /// Returns a copy with all elements transformed by the supplied function.
        /// </summary>
        public __nmtype1__ Copy(Func<__ftype__, int, int, __ftype1__> element_index0_index1_fun)
        {
            return new __nmtype1__(/*# n.ForEach(r => { */
                /*# m.ForEach(s => { */element_index0_index1_fun(M__r____s__, __r__, __s__)/*# }, comma); }, comma); */);
        }

        //# }
        //# if (m == n && m >= 3) {
        //#     var nmtype1x = "M" + (n-1) + (m-1);
        //#     var nmtype1 = nmtype1x + tchar;
        /// <summary>
        /// Returns a copy of the upper left sub matrix.
        /// </summary>
        public __nmtype1__ UpperLeft__nmtype1x__()
        {
            return (__nmtype1__)this;
        }

        //# }
        public __ftype__[] ToArray()
        {
            var array = new __ftype__[__nm__];
            //# n.ForEach(j => { m.ForEach(k => { var jk = j * m + k;
            array[__jk__] = M__j____k__;
            //# });});
            return array;
        }

        #endregion

        #region Static Factories

        public static __nmtype__ FromCols(/*# m.ForEach(r => {*/__vntype__ col__r__/*#}, comma); */)
        {
            return new __nmtype__(/*# n.ForEach(r => { */
                /*# m.ForEach(c => { var rf = fields[r]; */col__c__.__rf__/*#}, comma);}, comma); */);
        }

        public static __nmtype__ FromRows(/*# n.ForEach(r => {*/__vmtype__ row__r__/*#}, comma); */)
        {
            return new __nmtype__(/*# n.ForEach(r => { */
                /*# mfields.ForEach(f => {*/row__r__.__f__/*#}, comma);}, comma); */);
        }

        #endregion

        #region Properties and Indexers

        public bool IsValid { get { return true; } }
        public bool IsInvalid { get { return false; } }

        public IEnumerable<__ftype__> Elements
        {
            get
            {
                //# n.ForEach(j => { m.ForEach(k => {
                 yield return M__j____k__;
                //# });});
            }
        }

        public IEnumerable<__vmtype__> Rows
        {
            get
            {
                //# n.ForEach(k => { 
                yield return R__k__;
                //# });
            }
        }

        public IEnumerable<__vntype__> Columns
        {
            get
            {
                //# m.ForEach(k => { 
                yield return C__k__;
                //# });
            }
        }

        //# n.ForEach(k => { 
        public __vmtype__ R__k__
        {                     
            get { return new __vmtype__(/*# m.ForEach(f => {*/ M__k____f__/*#}, comma); */); }
            set
            {
                //# mfields.ForEach((f, j) => { 
                M__k____j__ = value.__f__;
                //# });
            }
        }

        //# });
        //# m.ForEach(k => {
        public __vntype__ C__k__
        {           
            get { return new __vntype__(/*# n.ForEach(f => {*/ M__f____k__/*#}, comma); */); }
            set
            {
                //# nfields.ForEach((f, j) => { 
                M__j____k__ = value.__f__;
            //# });
            }
        }

        //# });
        public __ftype__ this[int index]
        {
            get
            {
                switch (index)
                {
                    //# { int cs = 0;
                    //# n.ForEach(r => { m.ForEach(q => {
                    case __cs__: return M__r____q__;
                    //# cs++; }); }); }
                    default: throw new InvalidOperationException();
                }
            }
            set
            {
                switch (index)
                {
                    //# { int cs = 0;
                    //# n.ForEach(r => { m.ForEach(q => {
                    case __cs__: M__r____q__ = value; return;
                    //# cs++; }); }); }
                    default: throw new InvalidOperationException();
                }
            }
        }

        public __ftype__ this[int row, int column]
        {
            get
            {
                switch (row)
                {
                    //# n.ForEach(r => { 
                    case __r__: switch (column)
                            {
                                //# m.ForEach(c => {
                                case __c__: return M__r____c__;
                                //# });
                                default: throw new InvalidOperationException();
                            }
                    //# });
                    default: throw new InvalidOperationException();
                }
            }
            set
            {
                switch (row)
                {
                    //# n.ForEach(r => { 
                    case __r__: switch (column)
                            {
                                //# m.ForEach(c => {
                                case __c__: M__r____c__ = value; return;
                                //# });                       
                                default: throw new InvalidOperationException();
                            }
                    //# });
                    default: throw new InvalidOperationException();
                }
            }
        }

        #endregion

        #region Constants

        public const int RowCount = __n__;
        public const int ColumnCount = __m__;
        public const int ElementCount = __n__*__m__;

        public static readonly V2l Dimensions = new V2l(__n__, __m__);

        public static readonly __nmtype__ Zero
                = new __nmtype__(/*# (n*m).ForEach(k => {*/0/*#}, comma); */);

        public static readonly __nmtype__ Identity
                = new __nmtype__(/*# n.ForEach(i => { m.ForEach(j => { var v = i == j ? "1" : "0"; */__v__/*# }, comma); }, comma); */);

        #endregion

        #region Norms

        /// <summary>
        /// Returns the Manhattan (or 1-) norm of the matrix. This is
        /// calculated as |M00| + |M01| + ...
        /// </summary>
        public __ftype__ Norm1
        {
            get
            {
                return /*# n.ForEach(i => { */
                    /*# m.ForEach(j => { */Fun.Abs(M__i____j__)/*# }, add); }, add); */;
            }
        }

        /// <summary>
        /// Returns the Euclidean (or 2-) norm of the matrix. This is
        /// calculated as Sqrt(M00 * M00 + M01 * M01 + ... )
        /// </summary>
        public __ctype__ Norm2
        {
            get
            {
                return Fun.Sqrt(/*# n.ForEach(i => { */
                    /*# m.ForEach(j => { */M__i____j__ * M__i____j__/*# }, add); }, add); */);
            }
        }

        /// <summary>
        /// Returns the p-norm of the matrix. This is calculated as
        /// (|M00|^p + |M01|^p + ... )^(1/p)
        /// </summary>
        public __ctype__ Norm(__ctype__ p)
        {
            return (/*# n.ForEach(i => { m.ForEach(j => { */
                Fun.Abs(M__i____j__).Pow(p)/*# }, add); }, add); */
            ).Pow(1 / p);
        }

        /// <summary>
        /// Returns the infinite (or maximum) norm of the matrix. This is
        /// calculated as max(|M00|, |M01|, ...).
        /// </summary>
        public __ftype__ NormMax
        {
            get
            {
                return Fun.Max(/*# n.ForEach(i => { */
                            Fun.Max(/*# m.ForEach(j => { */
                                Fun.Abs(M__i____j__)/*# }, comma); */)/*# }, comma); */);
            }
        }

        /// <summary>
        /// Returns the minimum norm of the matrix. This is calculated as
        /// min(|M00|, |M01|, ...).
        /// </summary>
        public __ftype__ NormMin
        {
            get
            {
                return Fun.Min(/*# n.ForEach(i => { */
                            Fun.Min(/*# m.ForEach(j => { */
                                Fun.Abs(M__i____j__)/*# }, comma); */)/*# }, comma); */);
            }
        }

        /// <summary>
        /// Returns the Manhatten (or 1-) distance between two matrices.
        /// </summary>
        public static __ftype__ Distance1(__nmtype__ a, __nmtype__ b)
        {
            return/*# n.ForEach(i => { m.ForEach(j => { */
                Fun.Abs(b.M__i____j__ - a.M__i____j__)/*# }, add); }, add); */;
        }

        /// <summary>
        /// Returns the Euclidean (or 2-) distance between two matrices.
        /// </summary>
        public static __ctype__ Distance2(__nmtype__ a, __nmtype__ b)
        {
            return /*# if (ctype != "double") {*/(__ctype__)/*# } */Fun.Sqrt(/*# n.ForEach(i => { m.ForEach(j => { */
                        Fun.Square(b.M__i____j__ - a.M__i____j__)/*# }, add); }, add); */);
        }

        /// <summary>
        /// Returns the p-distance between two matrices.
        /// </summary>
        public static __ctype__ Distance(__nmtype__ a, __nmtype__ b, __ctype__ p)
        {
            return (/*# n.ForEach(i => { m.ForEach(j => { */
                Fun.Abs(b.M__i____j__ - a.M__i____j__).Pow(p)/*# }, add); }, add); */
            ).Pow(1 / p);
        }

        /// <summary>
        /// Returns the maximal absolute distance between the components of
        /// the two matrices.
        /// </summary>
        public static __ftype__ DistanceMax(__nmtype__ a, __nmtype__ b)
        {
            return Fun.Max(/*# n.ForEach(i => { */
                        Fun.Max(/*# m.ForEach(j => { */
                            Fun.Abs(b.M__i____j__ - a.M__i____j__)/*#
                                                }, comma); */)/*# }, comma); */);
        }

        /// <summary>
        /// Returns the minimal absolute distance between the components of
        /// the two matrices.
        /// </summary>
        public static __ftype__ DistanceMin(__nmtype__ a, __nmtype__ b)
        {
            return Fun.Min(/*# n.ForEach(i => { */
                        Fun.Min(/*# m.ForEach(j => { */
                            Fun.Abs(b.M__i____j__ - a.M__i____j__)/*#
                                                }, comma); */)/*# }, comma); */);
        }

        #endregion

        #region Mathematical Operators

        //# for (int o = 0; o < ops.Length; o++) { var op = ops[o];
        //#     for (int action = 0; action < 2; action++) { var opact = opaction[action, o]; 
        //#         for (int t1 = t; t1 < tcharA.Length; t1++) {
        //#             var nmtype1 = "M" + n + m + tcharA[t1];
        //#             var ftype1 = ftypeA[t1];
        //#             if (o != ops.Length-1) { 
        public static __nmtype1__ __opact__(__nmtype__ a, __nmtype1__ b)
        {
            return new __nmtype1__(/*# n.ForEach(r => { */
                /*# m.ForEach(s => { */a.M__r____s____op__b.M__r____s__/*# }, comma); }, comma); */);
        }

        //#             }
        public static __nmtype1__ __opact__(__nmtype__ m, __ftype1__ s)
        {
            return new __nmtype1__(/*# n.ForEach(r => { */
                /*# m.ForEach(s => { */m.M__r____s____op__s/*# }, comma); }, comma); */);
        }
        
        public static __nmtype1__ __opact__(__ftype1__ s, __nmtype__ m)
        {
            return new __nmtype1__(/*# n.ForEach(r => { */
                /*# m.ForEach(s => { */s__op__m.M__r____s__/*# }, comma); }, comma); */);
        }

        //#         }
        //#     }
        //# }
        #endregion

        #region Matrix/Vector Multiplication

        public static __vntype__ Multiply(__nmtype__ m, __vmtype__ v)
        {
            return new __vntype__(/*# n.ForEach(r => { */
                /*# m.ForEach(q => { var f = fields[q]; */m.M__r____q__ * v.__f__/*# },
                    add); }, comma); */);
        }

        public static __vntype__ operator *(__nmtype__ m, __vmtype__ v)
        {
            return new __vntype__(/*# n.ForEach(r => { */
                /*# m.ForEach(q => { var f = fields[q]; */m.M__r____q__ * v.__f__/*# },
                    add); }, comma); */);
        }

        //# if (m == n) {
        public static __vmtype__ TransposedMultiply(__vntype__ v, __nmtype__ m)
        {
            return new __vmtype__(/*# m.ForEach(q => { */
                /*# n.ForEach(r => { var f = fields[r]; */v.__f__ * m.M__r____q__/*# },
                    add); }, comma); */);
        }

        //# }
        #endregion

        #region Bool Operators

        //# for(int o = 0; o < bops.Length; o++) {
        //#     string bop = " " + bops[o] + " ", bopname = "operator " + bops[o];
        public static bool __bopname__(__nmtype__ a, __nmtype__ b)
        {
            return/*# n.ForEach(i => { m.ForEach(j => { */
                a.M__i____j____bop__b.M__i____j__/*#}, andand);}, andand);*/;
        }

        public static bool __bopname__(__nmtype__ a, __ftype__ s)
        {
            return/*# n.ForEach(i => { m.ForEach(j => { */
                a.M__i____j____bop__s/*# }, andand); }, andand); */;
        }

        public static bool __bopname__(__ftype__ s, __nmtype__ a)
        {
            return/*# n.ForEach(i => { m.ForEach(j => { */
                s__bop__a.M__i____j__ /*# }, andand); }, andand); */;
        }

        //# }
        public static bool operator !=(__nmtype__ a, __nmtype__ b)
        {
            return !(a == b);
        }
        
        public static bool operator !=(__nmtype__ m, __ftype__ s)
        {
            return !(m == s);
        }
        
        public static bool operator !=(__ftype__ s, __nmtype__ m)
        {
            return !(s == m);
        }

        #endregion

        #region Overrides

        public override int GetHashCode()
        {
            return HashCode.Combine(/*# n.ForEach(r => { */
                /*# m.ForEach(s => {*/M__r____s__.GetHashCode()/*# }, comma); }, comma); */); 
        }

        public override bool Equals(object other)
        {
            return (other is __nmtype__) ? (this == (__nmtype__)other) : false;
        }

        public override string ToString()
        {
            return ToString(null, Localization.FormatEnUS);
        }

        public string ToString(string format)
        {
            return ToString(format, Localization.FormatEnUS);
        }

        public string ToString(string format, IFormatProvider fp)
        {
            return ToString(format, fp, "[", ", ", "]", "[", ", ", "]");
        }

        /// <summary>
        /// Outputs e.g. a 2x2-Matrix in the form "(beginM)(beginR)m00(betweenR)m01(endR)(betweenM)(beginR)m10(betweenR)m11(endR)(endM)".
        /// </summary>
        public string ToString(string format, IFormatProvider fp, string beginM, string betweenM, string endM, string beginR, string betweenR, string endR)
        {
            if (fp == null) fp = Localization.FormatEnUS;
            return beginM/*# n.ForEach(r => {*/
                + R__r__.ToString(format, fp, beginR, betweenR, endR) /*# }, addbetweenM); */
            + endM;
        }
        
        public static __nmtype__ Parse(string s)
        {
            var x = s.NestedBracketSplitLevelOne().ToArray();
            return __nmtype__.FromRows(/*# n.ForEach(i => { */
                __vmtype__.Parse(x[__i__])/*# }, comma); */
            );
        }

        #endregion

        #region Transformations

        //# if (m == 2) {
        /// <summary>
        /// Transforms direction vector v (v.w is presumed 0.0) by matrix m.
        /// </summary>
        public static __ftype__ TransformDir(__nmtype__ m, __ftype__ v)
        {
            return m.M00 * v;
        }

        /// <summary>
        /// Transforms point p (v.w is presumed 1.0) by matrix m.
        /// No projective transform is performed.
        /// </summary>
        public static __ftype__ TransformPos(__nmtype__ m, __ftype__ p)
        {
            return m.M00 * p + m.M01;
        }

        /// <summary>
        /// Transforms point p (p.w is presumed 1.0) by matrix m. 
        /// Projective transform is performed. Perspective Division is performed.
        /// </summary>
        public static __ftype__ TransformPosProj(__nmtype__ m, __ftype__ p)
        {
            __ftype__ s = m.M10 * p + m.M11;
            s = 1 / s;
            return (TransformPos(m, p)) * s;
        }

        /// <summary>
        /// Transforms point p (p.w is presumed 1.0) by matrix m. 
        /// Projective transform is performed.
        /// </summary>
        public static __vmtype__ TransformPosProjFull(__nmtype__ m, __ftype__ p)
        {
            return new __vmtype__(TransformPos(m, p), m.M10 * p + m.M11);
        }

        /// <summary>
        /// Transforms direction vector v (v.w is presumed 0.0) by this matrix.
        /// </summary>
        public __ftype__ TransformDir(__ftype__ v)
        {
            return TransformDir(this, v);
        }

        public __ftype__ TransformPos(__ftype__ p)
        {
            return TransformPos(this, p);
        }

        public __ftype__ TransformPosProj(__ftype__ p)
        {
            return TransformPosProj(this, p);
        }

        public __vmtype__ TransformPosProjFull(__ftype__ p)
        {
            return TransformPosProjFull(this, p);
        }

        //# } else { // m != 2
        /// <summary>
        /// Transforms direction vector v (v.w is presumed 0.0) by matrix m.
        /// </summary>
        public static __vmsub1type__ TransformDir(__nmtype__ m, __vmsub1type__ v)
        {
            return new __vmsub1type__(/*# msub1.ForEach(s => { */
                /*# mfields.Take(msub1).ForEach((fr, r) => { */m.M__s____r__ * v.__fr__/*# }, add); }, comma); */
                );
        }

        /// <summary>
        /// Transforms point p (v.w is presumed 1.0) by matrix m.
        /// No projective transform is performed.
        /// </summary>
        public static __vmsub1type__ TransformPos(__nmtype__ m, __vmsub1type__ p)
        {
            return new __vmsub1type__(/*# msub1.ForEach(s => { */
                /*# mfields.Take(msub1).ForEach((fr, r) => { */m.M__s____r__ * p.__fr__/*# }, add); */ + m.M__s____msub1__/*# }, comma); */
                );
        }

        /// <summary>
        /// Transforms direction vector v (v.w is presumed 0.0) by this matrix.
        /// </summary>
        public __vmsub1type__ TransformDir(__vmsub1type__ v)
        {
            return new __vmsub1type__(/*# msub1.ForEach(s => { */
                /*# mfields.Take(msub1).ForEach((fr, r) => { */M__s____r__ * v.__fr__/*# }, add); }, comma); */
                );
        }

        /// <summary>
        /// Transforms point p (p.w is presumed 1.0) by this matrix.
        /// No projective transform is performed.
        /// </summary>
        public __vmsub1type__ TransformPos(__vmsub1type__ p)
        {
            return new __vmsub1type__(/*# msub1.ForEach(s => { */
                /*# mfields.Take(msub1).ForEach((fr, r) => { */M__s____r__ * p.__fr__/*# }, add); */ + M__s____msub1__/*# }, comma); */
                );
        }

        //# if (n == m) {
        /// <summary>
        /// Transforms direction vector v (v.w is presumed 0.0) by transposed version of matrix m.
        /// </summary>
        public static __vmsub1type__ TransposedTransformDir(__nmtype__ m, __vmsub1type__ v)
        {
            return new __vmsub1type__(/*# msub1.ForEach(s => { */
                /*# mfields.Take(msub1).ForEach((fr, r) => { */m.M__r____s__ * v.__fr__/*# }, add); }, comma); */
                );
        }

        /// <summary>
        /// Transforms point p (v.w is presumed 1.0) by transposed version of matrix m.
        /// No projective transform is performed.
        /// </summary>
        public static __vmsub1type__ TransposedTransformPos(__nmtype__ m, __vmsub1type__ p)
        {
            return new __vmsub1type__(/*# msub1.ForEach(s => { */
                /*# mfields.Take(msub1).ForEach((fr, r) => { */m.M__r____s__ * p.__fr__/*# }, add); */ + m.M__msub1____s__/*# }, comma); */
                );
        }

        /// <summary>
        /// Transforms direction vector v (v.w is presumed 0.0) by transposed version of this matrix.
        /// </summary>
        public __vmsub1type__ TransposedTransformDir(__vmsub1type__ v)
        {
            return new __vmsub1type__(/*# msub1.ForEach(s => { */
                /*# mfields.Take(msub1).ForEach((fr, r) => { */M__r____s__ * v.__fr__/*# }, add); }, comma); */
                );
        }

        /// <summary>
        /// Transforms point p (p.w is presumed 1.0) by transposed version of this matrix.
        /// No projective transform is performed.
        /// </summary>
        public __vmsub1type__ TransposedTransformPos(__vmsub1type__ p)
        {
            return new __vmsub1type__(/*# msub1.ForEach(s => { */
                /*# mfields.Take(msub1).ForEach((fr, r) => { */M__r____s__ * p.__fr__/*# }, add); */ + M__msub1____s__/*# }, comma); */
                );
        }

        /// <summary>
        /// Transforms point p (p.w is presumed 1.0) by matrix m.
        /// Projective transform is performed. Perspective Division is performed.
        /// </summary>
        public static __vmsub1type__ TransformPosProj(__nmtype__ m, __vmsub1type__ p)
        {
            __ftype__ s = (/*# mfields.Take(msub1).ForEach((fr, r) => { */m.M__msub1____r__ * p.__fr__ /*#}, add);*/+ m.M__msub1____msub1__);
            s = 1 / s;
            return (TransformPos(m, p)) * s;
        }

        /// <summary>
        /// Transforms point p (p.w is presumed 1.0) by matrix m.
        /// Projective transform is performed.
        /// </summary>
        public static __vmtype__ TransformPosProjFull(__nmtype__ m, __vmsub1type__ p)
        {
            return new __vmtype__(/*# m.ForEach(s => { */
                (/*# mfields.Take(msub1).ForEach((fr, r) => { */m.M__s____r__ * p.__fr__/*#}, add);*/+ m.M__s____msub1__)/*#}, comma);*/
                );
        }

        /// <summary>
        /// Transforms point p (p.w is presumed 1.0) by this matrix.
        /// Projective transform is performed. Perspective Division is performed.
        /// </summary>
        public __vmsub1type__ TransformPosProj(__vmsub1type__ p)
        {
            return TransformPosProj(this, p);
        }

        /// <summary>
        /// Transforms point p (p.w is presumed 1.0) by this matrix.
        /// Projective transform is performed.
        /// </summary>
        public __vmtype__ TransformPosProjFull(__vmsub1type__ p)
        {
            return TransformPosProjFull(this, p);
        }

        //# } else { // n != m
        /// <summary>
        /// Transforms point p (p.w is presumed 1.0) by matrix m.
        /// Projective transform is performed.
        /// </summary>
        public static __vmsub1type__ TransformPosProj(__nmtype__ m, __vmsub1type__ p)
        {
            return TransformDir(m, p);
        }
        /// <summary>
        /// Transforms point p (p.w is presumed 1.0) by this matrix.
        /// Projective transform is performed.
        /// </summary>
        public __vmsub1type__ TransformPosProj(__vmsub1type__ p)
        {
            return TransformDir(p);
        }

        //# } // n != m
        //# } // m != 2
        #endregion

        #region Matrix Operations

        /// <summary>
        /// Returns index-th row of this matrix.
        /// </summary>
        public __vmtype__ Row(int index)
        {
            switch (index)
            {
                //# n.ForEach(r => {
                case __r__: return R__r__;
                //# });
                default: throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// Returns index-th column of this matrix.
        /// </summary>
        public __vntype__ Column(int index)
        {
            switch (index)
            {
                //# m.ForEach(r => {
                case __r__: return C__r__;
                //# });
                default: throw new InvalidOperationException();
            }
        }

        //# if( m == n) {
        /// <summary>
        /// Returns the trace of this matrix.
        /// The trace is defined as the sum of the diagonal elements,
        /// and is only defined for square matrices.
        /// </summary>
        public __ftype__ Trace
        {
            get { return /*# n.ForEach(r => {*/M__r____r__/*# }, add);*/ ; }
        }

        /// <summary>
        /// Gets the determinant of this matrix.
        /// The determinant is only defined for square matrices.
        /// </summary>
        public __ftype__ Det
        {
            get
            {
            //# if (n == 2) {
                return M00 * M11 - M10 * M01;
            //# }
            //# if (n == 3) {
                if (M10 == 0 && M20 == 0 && M21 == 0)
                {
                    return M00 * M11 * M22;
                }
                return
                M00 * M11 * M22 - M00 * M12 * M21 +
                M01 * M12 * M20 - M01 * M10 * M22 +
                M02 * M10 * M21 - M02 * M11 * M20;
            //# }
            //# if (n == 4) {
                // using bottom row because elements M30, M31, and M32
                // are zero most of the time.
                __ftype__ d = 0;
                if (M30 != 0.0f) d -= M30 * (
                M01 * M12 * M23 + M02 * M13 * M21 + M03 * M11 * M22
                - M21 * M12 * M03 - M22 * M13 * M01 - M23 * M11 * M02
                );
                if (M31 != 0.0f) d += M31 * (
                M00 * M12 * M23 + M02 * M13 * M20 + M03 * M10 * M22
                - M20 * M12 * M03 - M22 * M13 * M00 - M23 * M10 * M02
                );
                if (M32 != 0.0f) d -= M32 * (
                M00 * M11 * M23 + M01 * M13 * M20 + M03 * M10 * M21
                - M20 * M11 * M03 - M21 * M13 * M00 - M23 * M10 * M01
                );
                if (M33 != 0.0f) d += M33 * (
                M00 * M11 * M22 + M01 * M12 * M20 + M02 * M10 * M21
                - M20 * M11 * M02 - M21 * M12 * M00 - M22 * M10 * M01
                );
                return d;
            //# }
            }
        }
        
        /// <summary>
        /// Returns the determinant of this matrix.
        /// The determinant is only defined for square matrices.
        /// </summary>
        public __ftype__ Determinant()
        {
            return Det;
        }

        /// <summary>
        /// Returns whether this matrix is invertible.
        /// A matrix is invertible if its determinant is not zero.
        /// </summary>
        public bool Invertible { get { return Det != 0; } }
        
        /// <summary>
        /// Returns whether this matrix is singular.
        /// A matrix is singular if its determinant is zero.
        /// </summary>
        public bool Singular { get { return Det == 0; } }

        /// <summary>
        /// Transposes this matrix (and returns this).
        /// </summary>
        public void Transpose()
        {
            //# for (int r = 1; r < n; r++) { r.ForEach(s => {
            Fun.Swap(ref M__r____s__, ref M__s____r__);
            //# }); }
        }
        
        /// <summary>
        /// Gets transpose of this matrix.
        /// </summary>
        public __nmtype__ Transposed
        {
            get
            {
                return new __nmtype__ {/*# n.ForEach(r => { */
                    /*# m.ForEach(s => { */M__r____s__ = M__s____r__/*# }, comma); }, comma); */
                };
            }
        }

        //# if (t > 1) {
        private static V2l s_luSize = new V2l(__n__, __n__);
        private static V2l s_luDelta = new V2l(1, __n__);

        /// <summary>
        /// Inverts the matrix using lu factorization in place. Returns true
        /// if the matrix was invertible, otherwise the matrix remains unchanged.
        /// </summary>
        public bool LuInvert()
        {
            var lu = new Matrix<double>((double[])this, 0, s_luSize, s_luDelta);
            var p = lu.LuFactorize();
            if (p == null) return false;
            this = (__nmtype__)(lu.LuInverse(p).Data);
            return true;
        }

        /// <summary>
        /// Returns the inverse of the matrix using lu factorization.
        /// If the matrix is not invertible, __nmtype__.Zero is returned.
        /// </summary>
        public __nmtype__ LuInverse()
        {
            var lu = new Matrix<double>((double[])this, 0, s_luSize, s_luDelta);
            var p = lu.LuFactorize();
            if (p == null) return __nmtype__.Zero;
            return (__nmtype__)(lu.LuInverse(p).Data);
        }

        /// <summary>
        /// Inverts the matrix in place. Returns true if the matrix was invertible,
        /// otherwise the matrix remains unchanged.
        /// </summary>
        public bool Invert() { return LuInvert();  }

        /// <summary>
        /// Returns the inverse of this matrix. If the matrix is not invertible
        /// __nmtype__.Zero is returned.
        /// </summary>
        public __nmtype__ Inverse { get { return LuInverse(); } }

        /// <summary>
        /// Returns if all entries in the matrix a are approximately equal to the respective entries in matrix b.
        /// </summary>
        public static bool ApproximatelyEquals(__nmtype__ a, __nmtype__ b, __ftype__ epsilon)
        {
            return DistanceMax(a, b) <= epsilon; //Inefficient implementation, no early exit of comparisons.
        }

        /// <summary>
        /// Returns if the matrix is the identity matrix I.
        /// </summary>
        public bool IsIdentity(__ftype__ epsilon)
        {
            return ApproximatelyEquals(this, Identity, epsilon);
        }

        /// <summary>
        /// Returns if the matrix is orthonormal (i.e. M * M^t == I)
        /// </summary>
        public bool IsOrthonormal(__ftype__ epsilon)
        {
            var i = this * this.Transposed;
            return i.IsIdentity(epsilon);
        }

        /// <summary>
        /// Returns if the matrix is orthogonal (i.e. all non-diagonal entries of M * M^t == 0)
        /// </summary>
        public bool IsOrthogonal(__ftype__ epsilon)
        {
            var i = this * this.Transposed;
            for (int j = 0; j < __n__; j++)
                i[j, j] = 1; //inefficient implementation: just leave out the comparisons at the diagonal entries.
            return i.IsIdentity(epsilon);
        }
        //# }
        //# }
        #endregion

        #region Matrix Multiplication

        //# for (int a = n; a <= n+1 && a < 5; a++) {
        //#     for (int o = 0; o < 2; o++) { 
        //#         var opname = oper[o];
        //# if(a == m) {
        public static M__n____a____tchar__ __opname__(M__n____a____tchar__ a, M__a____a____tchar__ b)
        {
            return new M__n____a____tchar__(/*# n.ForEach(r => { *//*# a.ForEach(s => { */
                /*# a.ForEach(u => {*/a.M__r____u__ * b.M__u____s__/*# }, add);}, comma);}, comma); */
             );
        }

        //# }
        //# if ((a == n) && (a < 4)) {
        //#     int b = a+1;
        //#     if( b == m) {
        public static M__n____b____tchar__ __opname__(M__n____a____tchar__ a, M__a____b____tchar__ b)
        {
            return new M__n____b____tchar__(/*# n.ForEach(r => { *//*# b.ForEach(s => { */
                /*# a.ForEach(u => {*/a.M__r____u__ * b.M__u____s__/*# }, add);}, comma);}, comma); */
             );
        }

        //#            }
        //#         }
        //#     }
        //#  }
        #endregion

        #region IMatrix<double>

        /// <summary>
        /// NOTE: this indexer has reversed order of coordinates with respect to
        /// the default indexer!!!
        /// </summary>
        public double this[long x, long y]
        {
            get
            {
                return /*# if (ftype != "double") { */(double)/*# } */this[(int)y, (int)x];
            }
            set
            {
                this[(int)y, (int)x] = /*# if (ftype != "double") { */(__ftype__)/*# } */value;
            }
        }

        /// <summary>
        /// NOTE: this indexer has reversed order of coordinates with respect to
        /// the default indexer!!!
        /// </summary>
        public double this[V2l v]
        {
            get
            {
                return /*# if (ftype != "double") { */(double)/*# } */this[(int)v.Y, (int)v.X];
            }
            set
            {
                this[(int)v.Y, (int)v.X] = /*# if (ftype != "double") { */(__ftype__)/*# } */value;
            }
        }

        #endregion

        #region IMatrix

        public V2l Dim
        {
            get { return Dimensions; }
        }

        public object GetValue(long x, long y)
        {
            return (object)this[(int)x, (int)y];
        }

        public void SetValue(object value, long x, long y)
        {
            this[(int)x, (int)y] = (__ftype__)value;
        }

        public object GetValue(V2l v)
        {
            return (object)this[(int)(v.X), (int)(v.Y)];
        }

        public void SetValue(object value, V2l v)
        {
            this[(int)(v.X), (int)(v.Y)] = (__ftype__)value;
        }

        #endregion
    }

    public class __nmtype__EqualityComparer : IEqualityComparer<__nmtype__>
    {
        public static readonly __nmtype__EqualityComparer Default
            = new __nmtype__EqualityComparer();

        #region IEqualityComparer<__nmtype__> Members

        public bool Equals(__nmtype__ v0, __nmtype__ v1)
        {
            return v0 == v1;
        }

        public int GetHashCode(__nmtype__ v)
        {
            return v.GetHashCode();
        }

        #endregion
    }

    #endregion

    //# } // t
    //# } // m
    //# } // n
}
