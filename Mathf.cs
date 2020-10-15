/**
 * == Inspoy Technology ==
 * Assembly: Instech.UnityRiderAutoCompletion
 * FileName: Mathf.cs
 * Created on 2020/10/15 by inspoy
 * All rights reserved.
 */

using System;
using JetBrains.Annotations;

namespace Instech.UnityRiderAutoCompletion
{
    public static class Mathf
    {
        [SourceTemplate]
        public static void Abs(this int self)
        {
            //$ Mathf.Abs($self$);
        }

        [SourceTemplate]
        public static void Abs(this float self)
        {
            //$ Mathf.Abs($self$);
        }

        [SourceTemplate]
        [Macro(Target = "min")]
        [Macro(Target = "max")]
        public static void Clamp(this int self)
        {
            //$ Mathf.Clamp($self$, $min$, $max$);
        }

        [SourceTemplate]
        [Macro(Target = "min")]
        [Macro(Target = "max")]
        public static void Clamp(this float self)
        {
            //$ Mathf.Clamp($self$, $min$, $max$);
        }
        
        [SourceTemplate]
        [Macro(Target = "to")]
        [Macro(Target = "t")]
        public static void Lerp(this float from)
        {
            //$ UnityEngine.Mathf.Lerp($from$, $to$, $t$);
        }

        [SourceTemplate]
        [Macro(Target = "p")]
        public static void Pow(this int self)
        {
            //$ Mathf.Pow($self$, $p$);
        }
        
        [SourceTemplate]
        [Macro(Target = "p")]
        public static void Pow(this float self)
        {
            //$ Mathf.Pow($self$, $p$);
        }
    }
}
