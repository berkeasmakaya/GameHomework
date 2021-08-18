using HomeWorkGame.Abstract;
using HomeWorkGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;

namespace HomeWorkGame.Adapters
{
    public class MernisServiceAdapter : IPlayerCheckService
    {
        public bool CheckIfRealPlayer(Player player)
        {
            //return true;
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(player.NationalityNo), player.FirstName, player.LastName, player.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
