using AppModelo.Model.Domain.Wrappers;
using AppModelo.Model.Infra.Services;

namespace AppModelo.Controller.External
{
    public class ViaCepController
    {
        /// <summary>
        /// Método público que retorna a classe ViaCepWrapper.
        /// </summary>
        /// <param name="cep"></param>
        /// <returns>Retorna a classe ViaCepWrapper</returns>
        public ViaCepWrapper  Obter(string cep)
        {
            var service = new ViaCepService();

            var viaCep = service.ObterDaApi(cep);
          
            
            return viaCep;
        }
    }
} 
