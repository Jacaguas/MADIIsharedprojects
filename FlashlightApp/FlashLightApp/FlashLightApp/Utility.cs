using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using System.Threading.Tasks;

namespace FlashLightApp
{
    public static class Utility
    {
        const int DELAY_BEFORE_LETTERS = 150;

        public static async Task ShortFlash()
        {          
                Task.Delay(DELAY_BEFORE_LETTERS).Wait();
                await Flashlight.TurnOnAsync();
                Task.Delay(250).Wait();
                await Flashlight.TurnOffAsync();            
        }

        public static async Task LongFlash()
        {
                Task.Delay(DELAY_BEFORE_LETTERS).Wait();
                await Flashlight.TurnOnAsync();
                Task.Delay(700).Wait();
                await Flashlight.TurnOffAsync();           
        }

        public static async Task A()
        {
            Task.Delay(DELAY_BEFORE_LETTERS).Wait();
            await ShortFlash();            
            await LongFlash();
           
        }
        public static async Task B()
        {
            Task.Delay(DELAY_BEFORE_LETTERS).Wait();

            await LongFlash();
            await ShortFlash();
            await ShortFlash();
            await ShortFlash();

        }
        public static async Task C()
        {
            Task.Delay(DELAY_BEFORE_LETTERS).Wait();

            await LongFlash();
            await ShortFlash();
            await LongFlash();
            await ShortFlash();

        }
        public static async Task D()
        {
            Task.Delay(DELAY_BEFORE_LETTERS).Wait();

            await LongFlash();
            await ShortFlash();
            await ShortFlash();

        }
        public static async Task E()
        {
            Task.Delay(DELAY_BEFORE_LETTERS).Wait();
            await ShortFlash();           
        }
        public static async Task F()
        {
            Task.Delay(DELAY_BEFORE_LETTERS).Wait();
            await ShortFlash();            
            await ShortFlash();
            await LongFlash();
            await ShortFlash();
        }
        public static async Task G()
        {
            Task.Delay(DELAY_BEFORE_LETTERS).Wait();
            await LongFlash();
            await LongFlash();
            await ShortFlash();
        }
        public static async Task H()
        {
            Task.Delay(DELAY_BEFORE_LETTERS).Wait();
            await ShortFlash();
            await ShortFlash();
            await ShortFlash();
            await ShortFlash();
        }
        public static async Task I()
        {
            Task.Delay(DELAY_BEFORE_LETTERS).Wait();
            await ShortFlash();
            await ShortFlash();
        }
        public static async Task J()
        {
            Task.Delay(DELAY_BEFORE_LETTERS).Wait();
            await ShortFlash();
            await LongFlash();
            await LongFlash();
            await LongFlash();
        }
        public static async Task K()
        {
            Task.Delay(DELAY_BEFORE_LETTERS).Wait();
            await LongFlash();
            await ShortFlash();
            await LongFlash();
            
        }
        public static async Task L()
        {
            Task.Delay(DELAY_BEFORE_LETTERS).Wait();
            await ShortFlash();
            await LongFlash();
            await ShortFlash();
            await ShortFlash();
        }
        public static async Task M()
        {
            Task.Delay(DELAY_BEFORE_LETTERS).Wait();
            await LongFlash();
            await LongFlash();

        }
        public static async Task N()
        {
            Task.Delay(DELAY_BEFORE_LETTERS).Wait();
            await LongFlash();
            await ShortFlash();
           
        }
        public static async Task O()
        {
            Task.Delay(DELAY_BEFORE_LETTERS).Wait();
            await LongFlash();
            await LongFlash();
            await LongFlash();
        }
        public static async Task P()
        {
            Task.Delay(DELAY_BEFORE_LETTERS).Wait();
            await ShortFlash();
            await LongFlash();            
            await LongFlash();
            await ShortFlash();
        }
        public static async Task Q()
        {
            Task.Delay(DELAY_BEFORE_LETTERS).Wait();
            await LongFlash();
            await LongFlash();
            await ShortFlash();
            await LongFlash();
        }
        public static async Task R()
        {
            Task.Delay(DELAY_BEFORE_LETTERS).Wait();
            await ShortFlash();
            await LongFlash();
            await ShortFlash();
        }
        public static async Task S()
        {
            Task.Delay(DELAY_BEFORE_LETTERS).Wait();
            await ShortFlash();
            await ShortFlash();
            await ShortFlash();
        }
        public static async Task T()
        {
            Task.Delay(DELAY_BEFORE_LETTERS).Wait();
            await LongFlash();
        }
        public static async Task U()
        {
            Task.Delay(DELAY_BEFORE_LETTERS).Wait();
            await ShortFlash();            
            await ShortFlash();
            await LongFlash();
        }
        public static async Task V()
        {
            Task.Delay(DELAY_BEFORE_LETTERS).Wait();
            await ShortFlash();
            await ShortFlash();
            await ShortFlash();
            await LongFlash();
        }
        public static async Task W()
        {
            Task.Delay(DELAY_BEFORE_LETTERS).Wait();
            await ShortFlash();            
            await LongFlash();
            await LongFlash();
        }
        public static async Task X()
        {
            Task.Delay(DELAY_BEFORE_LETTERS).Wait();
            await LongFlash();
            await ShortFlash();
            await ShortFlash();
            await LongFlash();
        }
        public static async Task Y()
        {
            Task.Delay(DELAY_BEFORE_LETTERS).Wait();
            await LongFlash();
            await ShortFlash();
            await LongFlash();
            await LongFlash();
        }
        public static async Task Z()
        {
            Task.Delay(DELAY_BEFORE_LETTERS).Wait();
            await LongFlash();            
            await LongFlash();
            await ShortFlash();
            await ShortFlash();
        }


    }
}
