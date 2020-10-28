using IndianStatesCensusAnalyser;
using NUnit.Framework;
using System.Collections.Generic;

namespace IndianCensusTest
{
    public class Tests
    {
        static string indianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";
        static string indianStateCodeHeaders = "SrNo,State Name,TIN,StateCode";
        static string indianStateCensusFilePath = @"D:\Capgemini\BridgeLabs Lectures\Week6\Census\IndianCensusTest\CSVFiles\IndiaStateCensusData.csv";
        static string wrongHeaderIndianCensusFilePath = @"D:\Capgemini\BridgeLabs Lectures\Week6\Census\IndianCensusTest\CSVFiles\WrongIndiaStateCensusData.csv";
        static string delimiterIndianCensusFlePath = @"D:\Capgemini\BridgeLabs Lectures\Week6\Census\IndianCensusTests\CSVFiles\ACFrOgC8X-aU0MPsLvIPqiuE-eCVBo9zFKPIEmX-tLZXtvD0LC-NbQDrh3KyKOWhYom6B5l0KY_sBlxpoOuxqBggb1Nxdho_Dduezam6eOe8XDutB4tYLPetuTxPZELjclgnFBdkIuQVxQyF4wVn.pdf";
        static string wrongIndianStateCensusFilepath = @"D:\Capgemini\BridgeLabs Lectures\Week6\Census\IndianCensusTest\CSVFiles\WrongIndiaStateCensusData.csv";
        /*static string wrongIndianStateStateCensusFileType =;*/
        static string indianStateCodeFilePath = @"D:\Capgemini\BridgeLabs Lectures\Week6\Census\IndianCensusTest\CSVFiles\IndiaStateCode.csv";
        /*static string wrongIndianStateCodeFileType =;
        static string delimiterIndianStateCodeFilePath =;
        static string wrongHeaderStateCodeFilePath =;*/

        CensusAnalyser censusAnalyser;
        Dictionary<string, IndianStatesCensusAnalyser.DTO.CensusDTO> totalRecord;
        Dictionary<string, IndianStatesCensusAnalyser.DTO.CensusDTO> stateRecord;

        [SetUp]
        public void Setup()
        {
            censusAnalyser = new CensusAnalyser();
            totalRecord = new Dictionary<string, IndianStatesCensusAnalyser.DTO.CensusDTO>();
            stateRecord = new Dictionary<string, IndianStatesCensusAnalyser.DTO.CensusDTO>();
        }

        [Test]
        public void TestMethod1()
        {
            totalRecord = censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, indianStateCensusFilePath, indianStateCensusHeaders);
            stateRecord = censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, indianStateCodeFilePath, indianStateCodeHeaders);

            Assert.AreEqual(29, totalRecord.Count);
            Assert.AreEqual(37, stateRecord.Count);
        }
    }
}