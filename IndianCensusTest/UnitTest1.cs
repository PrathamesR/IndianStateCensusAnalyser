using IndianStatesCensusAnalyser;
using NUnit.Framework;
using System.Collections.Generic;

namespace IndianCensusTest
{
    public class Tests
    {
        static string indianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";
        static string indianStateCodeHeaders = "SrNo,State Name,TIN,StateCode";
        static string wrongIndianStateCensusFileType = @"D:\Capgemini\BridgeLabs Lectures\Week6\Census\IndianCensusTest\CSVFiles\WrongIndiaStateCode.txt";
        static string wrongIndianStateCodeFileType = @"D:\Capgemini\BridgeLabs Lectures\Week6\Census\IndianCensusTest\CSVFiles\WrongIndiaStateCensusData.txt";
        static string indianStateCensusFilePath = @"D:\Capgemini\BridgeLabs Lectures\Week6\Census\IndianCensusTest\CSVFiles\IndiaStateCensusData.csv";
        static string delimiterIndianCensusFlePath = @"D:\Capgemini\BridgeLabs Lectures\Week6\Census\IndianCensusTest\CSVFiles\DelimiterIndiaStateCensusData.csv";
        static string wrongIndianStateCensusFilePath = @"D:\Capgemini\BridgeLabs Lectures\Week6\Census\IndianCensussdTest\CSVFiles\WrongIndiaStateCensusData.csv";  
        static string indianStateCodeFilePath = @"D:\Capgemini\BridgeLabs Lectures\Week6\Census\IndianCensusTest\CSVFiles\IndiaStateCode.csv";
        static string delimiterIndianStateCodeFilePath =@"D:\Capgemini\BridgeLabs Lectures\Week6\Census\IndianCensusTest\CSVFiles\DelimiterIndiaStateCode.csv";
        static string wrongHeaderStateCodeFilePath =@"D:\Capgemini\BridgeLabs Lectures\Week6\Census\IndianCensusTest\CSVFiles\WrongIndiaStateCode.csv";

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

        [Test]
        public void TestMethod2()
        {
            var censusException = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, wrongIndianStateCensusFilePath, indianStateCensusHeaders));
            var stateException = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, wrongIndianStateCensusFilePath, indianStateCodeHeaders));
            Assert.AreEqual(CensusAnalyserException.ExceptionType.FILE_NOT_FOUND, censusException.eType);
            Assert.AreEqual(CensusAnalyserException.ExceptionType.FILE_NOT_FOUND, stateException.eType);
        }

        [Test]
        public void TestMethod3()
        {
            var censusException = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, delimiterIndianCensusFlePath, indianStateCensusHeaders));
            var stateException = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, delimiterIndianStateCodeFilePath, indianStateCodeHeaders));
            Assert.AreEqual(CensusAnalyserException.ExceptionType.INCORRECT_DELIMITER, censusException.eType);
            Assert.AreEqual(CensusAnalyserException.ExceptionType.INCORRECT_DELIMITER, stateException.eType);
        }

        [Test]
        public void TestMethod4()
        {
            var censusException = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, indianStateCensusFilePath, wrongIndianStateCensusFilePath));
            var stateException = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, indianStateCodeFilePath, wrongHeaderStateCodeFilePath));
            Assert.AreEqual(CensusAnalyserException.ExceptionType.INCORRECT_HEADER, censusException.eType);
            Assert.AreEqual(CensusAnalyserException.ExceptionType.INCORRECT_HEADER, stateException.eType);
        }

        [Test]
        public void TestCase5()
        {
            var censusException = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, wrongIndianStateCensusFileType, indianStateCensusHeaders));
            var stateException = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, wrongIndianStateCodeFileType, indianStateCodeHeaders));
            Assert.AreEqual(CensusAnalyserException.ExceptionType.INVALID_FILE_TYPE, censusException.eType);
            Assert.AreEqual(CensusAnalyserException.ExceptionType.INVALID_FILE_TYPE, stateException.eType);
        }
    }
}