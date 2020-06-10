using System.Collections.Generic;
using System.Threading.Tasks;
using Infraero.Relprev.Application.AtribuicaoRelato.Commands.CreateResponsavelTecnico;
using Infraero.Relprev.Application.AtribuicaoRelato.Commands.CreateAtribuicaoRelato;
using Infraero.Relprev.Application.AtribuicaoRelato.Commands.UpdateAtribuicaoRelato;
//using Infraero.Relprev.Application.AtribuicaoRelato.Commands.DeleteAtribuicaoRelato;
using Infraero.Relprev.Application.AtribuicaoRelato.Queries.GetAtribuicaoRelatos;


namespace Infraero.Relprev.CoreApiClient
{
    public partial class ApiClient
    {
       private const string ResourceAtribuicaoRelato = "AtribuicaoRelato";

        #region Main Methods

        public Task<long> CreateAtribuicaoRelato(CreateAtribuicaoRelatoCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceAtribuicaoRelato}/CreateAtribuicaoRelato"));
            return Post(requestUrl, command);
        }
        public Task<long> UpdateAtribuicaoRelato(UpdateAtribuicaoRelatoCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceAtribuicaoRelato}/UpdateAtribuicaoRelato"));
            return Post(requestUrl, command);
        }
        //public Task<long> DeleteAtribuicaoRelato(DeleteAtribuicaoRelatoCommand command)
        //{
        //    var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
        //        $"{ResourceAtribuicaoRelato}/DeleteAtribuicaoRelato"));
        //    return Post(requestUrl, command);

        //}
        public Task<long> AtribuirResponsavelTecnico(CreateResponsavelTecnicoCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceAtribuicaoRelato}/AtribuirResponsavelTecnico"));
            return Post(requestUrl, command);
        }

      
        #endregion

        #region Methods

        public AtribuicaoRelatoDto GetAtribuicaoRelatoById(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceAtribuicaoRelato}/GetAtribuicaoRelatoById/{id}"));
            return Get<AtribuicaoRelatoDto>(requestUrl);
        }
        public List<AtribuicaoRelatoDto> GetAtribuicaoByIdRelato(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceAtribuicaoRelato}/GetAtribuicaoByIdRelato/{id}"));
            return Get<List<AtribuicaoRelatoDto>>(requestUrl);
        }
        


        #endregion

    }
}