using Blazored.Modal;
using Blazored.Modal.Services;
using System.Reflection;
using YemekSiparis.CustomComponent.ModalComponents;

namespace YemekSiparis.Utils
{
    public class ModalManager
    {
        private readonly IModalService modalService;
        public ModalManager(IModalService modalService)
        {
            this.modalService = modalService;
        }
        public async Task ShowMessageAsync(String title,String Message,int duration=0)
        {

            ModalParameters mParams = new ModalParameters();
            mParams.Add("Message", Message);
            var modalRef=modalService.Show<ShowMessagePopupComponent>(title, mParams);
            if (duration > 0)
            {
                await Task.Delay(duration);//girilen ms kadar bekletir kapatir
                modalRef.Close();
            }
            await modalRef.Result;//modal dan donen değeri alir
        }
        public async Task<bool> ConfirmationAsync(String title, String Message)
        {

            ModalParameters mParams = new ModalParameters();
            mParams.Add("Message", "Cevabiniz Nedir?");
            var modalRef = modalService.Show<ConfirmationPopupComponent>(title,mParams);
           
            var ModalResult= modalRef.Result;//modal dan donen değeri alir
            return !ModalResult.IsCanceled;//onay mi red mi gonderir
        }
    }
}
