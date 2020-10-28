using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {

            string indianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";
            string indianStateCodeHeaders = "SrNo,State Name,TIN,StateCode";
            string indianStateCensusFilePath = @"D:\Capgemini\BridgeLabs Lectures\Week6\Census\IndianCensusTest\CSVFiles\IndiaStateCensusData.csv";
            //static string wrongHeaderIndianCensusFilePath =;
            string delimiterIndianCensusFlePath = @"D:\Capgemini\BridgeLabs Lectures\Week6\Census\IndianCensusTests\CSVFiles\ACFrOgC8X-aU0MPsLvIPqiuE-eCVBo9zFKPIEmX-tLZXtvD0LC-NbQDrh3KyKOWhYom6B5l0KY_sBlxpoOuxqBggb1Nxdho_Dduezam6eOe8XDutB4tYLPetuTxPZELjclgnFBdkIuQVxQyF4wVn.pdf";
            /* static string wrongIndianStateCensusFilepath = ;
             static string wrongIndianStateStateCensusFileType =;*/
            string indianStateCodeFilePath = @"D:\Capgemini\BridgeLabs Lectures\Week6\Census\IndianCensusTest\CSVFiles\IndiaStateCode.csv";

            CensusAnalyser censusAnalyser;
            Dictionary<string, IndianStatesCensusAnalyser.DTO.CensusDTO> totalRecord;

            censusAnalyser = new CensusAnalyser();
            totalRecord = new Dictionary<string, IndianStatesCensusAnalyser.DTO.CensusDTO>();

            totalRecord = censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, indianStateCodeFilePath, indianStateCodeHeaders);
        }
    }
}
