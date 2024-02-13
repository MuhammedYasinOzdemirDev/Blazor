using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Pages
{
    public class Counter2Base:ComponentBase
    {
        protected int currentCount = 0;//varsayilan değer atanir fakat diğer sayfalardan erişip farklı değerle başlatılabilir

        protected void IncrementCount()//sadece miras alınan erişme sağlar
        {
            currentCount++;
        }
    }
}
