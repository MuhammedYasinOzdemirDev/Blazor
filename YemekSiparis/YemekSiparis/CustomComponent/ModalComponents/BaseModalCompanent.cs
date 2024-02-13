using Blazored.Modal;
using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;
using System.ComponentModel;

namespace YemekSiparis.CustomComponent.ModalComponents
{
    public class BaseModalCompanent:ComponentBase
    {
        [Parameter]
        public string Message { get; set; }
        [Parameter]
        public string OkText { get; set; }
        [Parameter]
        public string CancelText { get; set; }
        [Parameter]
        public string YesText { get; set; }
        [Parameter]
        public string NoText { get; set; }
        [CascadingParameter]
        BlazoredModalInstance ModalInstance { get; set; }//Modal özelliklerini değiştirmek tusa basıldımı çıkma vs işlemleri yapar
        
        protected async Task ConfirmClicked()//Sadece miras verilen classını kullanabildiği Tamam basınca cıkan metod yazılır
        {
            await ModalInstance.CloseAsync(ModalResult.Ok());

        }
        protected async Task CancelClicked()//Sadece miras verilen classını kullanabildiği Tamam basınca cıkan metod yazılır
        {
            await ModalInstance.CloseAsync(ModalResult.Cancel());

        }

    }
}
