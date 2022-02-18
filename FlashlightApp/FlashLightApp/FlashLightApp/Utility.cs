using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using System.Threading.Tasks;

namespace FlashLightApp
{
    public static class Utility
    {
        public static async Task ShortFlash()
        {          
                Task.Delay(100).Wait();
                await Flashlight.TurnOnAsync();
                Task.Delay(500).Wait();
                await Flashlight.TurnOffAsync();            
        }

        public static async Task LongFlash()
        {
          
                await Flashlight.TurnOnAsync();

                Task.Delay(700).Wait();

                await Flashlight.TurnOffAsync();
           
        }

        public static async Task A()
        {
            await ShortFlash();            
            await LongFlash();
           
        }
        public static async Task B()
        {

            await LongFlash();
            await ShortFlash();
            await ShortFlash();
            await ShortFlash();

        }
        public static async Task C()
        {

            await LongFlash();
            await ShortFlash();
            await LongFlash();
            await ShortFlash();

        }
        public static async Task D()
        {

            await LongFlash();
            await ShortFlash();
            await ShortFlash();

        }
        public static async Task E()
        {            
            await ShortFlash();           
        }
        public static async Task F()
        {            
            await ShortFlash();            
            await ShortFlash();
            await LongFlash();
            await ShortFlash();
        }
        public static async Task G()
        {
            await LongFlash();
            await LongFlash();
            await ShortFlash();
        }
        public static async Task H()
        {            
            await ShortFlash();
            await ShortFlash();
            await ShortFlash();
            await ShortFlash();
        }
        public static async Task I()
        {
            await ShortFlash();
            await ShortFlash();
        }
        public static async Task J()
        {
            await ShortFlash();
            await LongFlash();
            await LongFlash();
            await LongFlash();
        }
        public static async Task K()
        {            
            await LongFlash();
            await ShortFlash();
            await LongFlash();
            
        }
        public static async Task L()
        {            
            await ShortFlash();
            await LongFlash();
            await ShortFlash();
            await ShortFlash();
        }
        public static async Task M()
        {
            await LongFlash();
            await LongFlash();

        }
        public static async Task N()
        {
            await LongFlash();
            await ShortFlash();
           
        }
        public static async Task O()
        {
            await LongFlash();
            await LongFlash();
            await LongFlash();
        }
        public static async Task P()
        {
            await ShortFlash();
            await LongFlash();            
            await LongFlash();
            await ShortFlash();
        }
        public static async Task Q()
        {
            await LongFlash();
            await LongFlash();
            await ShortFlash();
            await LongFlash();
        }
        public static async Task R()
        {            
            await ShortFlash();
            await LongFlash();
            await ShortFlash();
        }
        public static async Task S()
        {
            await ShortFlash();
            await ShortFlash();
            await ShortFlash();
        }
        public static async Task T()
        {
            await LongFlash();
        }
        public static async Task U()
        {
            await ShortFlash();            
            await ShortFlash();
            await LongFlash();
        }
        public static async Task V()
        {
            await ShortFlash();
            await ShortFlash();
            await ShortFlash();
            await LongFlash();
        }
        public static async Task W()
        {
            await ShortFlash();            
            await LongFlash();
            await LongFlash();
        }
        public static async Task X()
        {
            await LongFlash();
            await ShortFlash();
            await ShortFlash();
            await LongFlash();
        }
        public static async Task Y()
        {
            await LongFlash();
            await ShortFlash();
            await LongFlash();
            await LongFlash();
        }
        public static async Task Z()
        {
            await LongFlash();            
            await LongFlash();
            await ShortFlash();
            await ShortFlash();
        }


    }
}
