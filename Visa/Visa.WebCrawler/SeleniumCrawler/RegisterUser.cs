﻿using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Globalization;
using System.Threading;
using ToolsPortable;
using Visa.Database;

namespace Visa.WebCrawler.SeleniumCrawler
{
    public class RegisterUser
    {
        #region Members

        private const string visaCategory = "ctl00_plhMain_cboVisaCategory"; //Візова категорія
        private const string buttonSubmit = "ctl00_plhMain_btnSubmit";//Підтвердити          
        private const string visaCity = "ctl00_plhMain_cboVAC"; //Візовий Сервіс Центр i Пункт Прийому Візових Анкетx
        private const string mainUrl = "https://polandonline.vfsglobal.com/poland-ukraine-appointment/%28S%28vvzibb45kxnimzfrnhuavib1%29%29/AppScheduling/AppWelcome.aspx?P=s2x6znRcBRv7WQQK7h4MTjZiPRbOsXKqJzddYBh3qCA=";
        private const string registryId = "ctl00_plhMain_lnkSchApp"; // Призначити дату подачі документів
        private const string reason = "ctl00_plhMain_cboPurpose"; //Мета візиту
        private const string numOfApplicants = "ctl00_plhMain_tbxNumOfApplicants"; //Кількість заявників
        private const string numOfChildrens = "ctl00_plhMain_txtChildren"; //К-сть дітей вписаних у паспорт батьків
        private const string receiptNumber = "ctl00_plhMain_repAppReceiptDetails_ctl01_txtReceiptNumber";//Номер квитанції
        private const string buttonSubmitEmail = "ctl00_plhMain_btnSubmitDetails"; //Підтвердити імейл
        private const string email = "ctl00_plhMain_txtEmailID";
        private const string passForMail = "ctl00_plhMain_txtPassword";
        private const string errorMessage = "ctl00_plhMain_lblMsg"; //Ок текст - на коли можна зареєструватись
        private const string endPassportDate = "ctl00_plhMain_repAppVisaDetails_ctl01_tbxPPTEXPDT";//Дата закінчення терміну дії паспорту
        private const string statusField = "ctl00_plhMain_repAppVisaDetails_ctl01_cboTitle"; //Статус
        private const string personName = "ctl00_plhMain_repAppVisaDetails_ctl01_tbxFName"; //Ім'я
        private const string personLastName = "ctl00_plhMain_repAppVisaDetails_ctl01_tbxLName"; //Прізвище
        private const string personBirthday = "ctl00_plhMain_repAppVisaDetails_ctl01_tbxDOB"; //Дата народження
        private const string returnDate = "ctl00_plhMain_repAppVisaDetails_ctl01_tbxReturn"; //Дата повернення
        private const string nationality = "ctl00_plhMain_repAppVisaDetails_ctl01_cboNationality"; //Національність
        private const string availableData = "OpenDateAllocated"; //Будь ласка, оберіть Вільну дату
        private const string registryTime = "ctl00_plhMain_gvSlot_ctl02_lnkTimeSlot"; //Будь ласка, оберіть Час

        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        private IWebDriver _driver;

        #endregion

        public bool Error { get; private set; }
        public string OutData { get; private set; }

        public RegisterUser()
        {
            _logger.Trace("Start RegisterUser constructor");
            _driver = new FirefoxDriver();
            _logger.Trace("End RegisterUser constructor");
        }

        public void PartOne(VisaDataSet.ClientDataRow dataRow, int serCenId, int visaCatId)
        {
            _logger.Info(
                $"Start PartOne. Error = {Error}. Service Center Id = {serCenId}.  Visa Category Id = {visaCatId}. dataRow.NumberOfReceipt = {dataRow.NumberOfReceipt}");
            try
            {
                _driver.Navigate().GoToUrl(mainUrl);
                Thread.Sleep(2000);
                {
                    var query = _driver.FindElement(By.Id(registryId));
                    _logger.Info("PartOne. registryId Click");
                    query.Click();
                }
                Thread.Sleep(2000);
                {
                    _driver.FindElement(By.Id(visaCity))
                        .FindElement(By.CssSelector($"option[value=\"{serCenId}\"]"))
                        .Click();
                    _logger.Info($"PartOne. visaCity option[value={serCenId}]  Click");
                }
                //Thread.Sleep(2000);
                {
                    //always be 1 - Подача документів
                    _driver.FindElement(By.Id(reason))
                        .FindElement(By.CssSelector("option[value='1']"))
                        .Click();
                    _logger.Info("PartOne. reason option[value='1'] Click");
                }
                //Thread.Sleep(2000);
                {
                    _driver.FindElement(By.Id(buttonSubmit))
                        .Click();
                    _logger.Info("PartOne. buttonSubmit Click");
                }
                Thread.Sleep(2000);
                {
                    var query = _driver.FindElement(By.Id(numOfApplicants));
                    _logger.Info($"PartOne. numOfApplicants Clear and set {dataRow.PeopleCount}");
                    query.Clear();
                    query.SendKeys(dataRow.PeopleCount);
                }
                //Thread.Sleep(2000);
                {
                    var query = _driver.FindElement(By.Id(numOfChildrens));
                    _logger.Info($"PartOne. numOfChildrens Clear and set {dataRow.ChildsCount}");
                    query.Clear();
                    query.SendKeys(dataRow.ChildsCount);
                }
                //Thread.Sleep(2000);
                {
                    _driver.FindElement(By.Id(visaCategory))
                        .FindElement(By.CssSelector($"option[value=\"{visaCatId}\"]"))
                        .Click();
                    _logger.Info($"PartOne. visaCategory option[value={visaCatId}]  Click");
                }
            }
            catch (NoSuchElementException ex)
            {
                _logger.Error($"NoSuchElementException with message = {ex.Message}");
                Error = true;
            }
            _logger.Info($"End PartOne. Error = {Error}");
        }

        public void PartTwo(VisaDataSet.ClientDataRow dataRow)
        {
            _logger.Info($"Start PartTwo. Error = {Error}. dataRow.NumberOfReceipt = {dataRow.NumberOfReceipt}");
            try
            {
                //Thread.Sleep(2000);
                {
                    _driver.FindElement(By.Id(buttonSubmit)).Click();
                    _logger.Info("PartTwo. buttonSubmit Click");
                }
                Thread.Sleep(2000);
                {
                    _driver.FindElement(By.Id(receiptNumber))
                        .SendKeys(dataRow.NumberOfReceipt);
                    _logger.Info($"PartTwo. receiptNumber set text {dataRow.NumberOfReceipt}");
                }
                //Thread.Sleep(2000);
                {
                    _driver.FindElement(By.Id(buttonSubmit))
                        .Click();
                    _logger.Info("PartTwo. buttonSubmit Click");
                }
                CheckForError();
                Thread.Sleep(2000);
                {
                    _driver.FindElement(By.Id(email))
                        .SendKeys(dataRow.Email);
                    _logger.Info($"PartTwo. email set text {dataRow.Email}");
                }
                //Thread.Sleep(2000);
                {
                    _driver.FindElement(By.Id(passForMail))
                        .SendKeys(dataRow.Password);
                    _logger.Info($"PartTwo. passForMail set text {dataRow.Password}");
                }
                //Thread.Sleep(2000);
                {
                    _driver.FindElement(By.Id(buttonSubmitEmail))
                        .Click();
                    _logger.Info("PartTwo. buttonSubmitEmail Click");
                }
                Thread.Sleep(2000);
                {
                    _driver.FindElement(By.Id(endPassportDate))
                        .SendKeys(dataRow.EndPassportDate.ToString(CultureInfo.CurrentCulture));
                    _logger.Info($"PartTwo. endPassportDate set text {dataRow.EndPassportDate.ToString(CultureInfo.CurrentCulture)}");
                }
                //Thread.Sleep(2000);
                {
                    _driver.FindElement(By.Id(statusField))
                        .FindElement(By.CssSelector($"option[value=\"{dataRow.Status}\"]"))
                        .Click();
                    _logger.Info($"PartTwo. statusField option[value={dataRow.Status}] Click");
                }
                //Thread.Sleep(2000);
                {
                    _driver.FindElement(By.Id(personName))
                        .SendKeys(dataRow.Name);
                    _logger.Info($"PartTwo. personName set text {dataRow.Name}");
                }
                //Thread.Sleep(2000);
                {
                    _driver.FindElement(By.Id(personLastName))
                        .SendKeys(dataRow.LastName);
                    _logger.Info($"PartTwo. personLastName set text {dataRow.LastName}");
                }
                //Thread.Sleep(2000);
                {
                    _driver.FindElement(By.Id(personBirthday))
                        .SendKeys(dataRow.Birthday.ToString(CultureInfo.CurrentCulture));
                    _logger.Info($"PartTwo. personBirthday set text {dataRow.Birthday.ToString(CultureInfo.CurrentCulture)}");
                }
                //Thread.Sleep(2000);
                {
                    _driver.FindElement(By.Id(returnDate))
                        .SendKeys(dataRow.ReturnData.ToString(CultureInfo.CurrentCulture));
                    _logger.Info($"PartTwo. returnDate set text {dataRow.ReturnData.ToString(CultureInfo.CurrentCulture)}");
                }
                //Thread.Sleep(2000);
                {
                    _driver.FindElement(By.Id(nationality))
                        .SendKeys(dataRow.Nationality);
                    _logger.Info($"PartTwo. nationality set text {dataRow.Nationality}");
                }
            }
            catch (NoSuchElementException ex)
            {
                _logger.Error($"NoSuchElementException with message = {ex.Message}");
                Error = true;
            }
            _logger.Info($"End PartTwo. Error = {Error}");
        }

        public void PartThree(VisaDataSet.ClientDataRow dataRow)
        {
            _logger.Info($"Start PartThree. Error = {Error}. dataRow.NumberOfReceipt = {dataRow.NumberOfReceipt}");
            try
            {
                Thread.Sleep(2000);
                {
                    var queryCollection = _driver.FindElements(By.ClassName(availableData));
                    _logger.Info($"PartThree. maxDate = { dataRow.RegistryFom.Day}. minDate = {dataRow.RegistryTo.Day}");
                    foreach (var element in queryCollection)
                    {
                        var date = element.Text.ConvertToIntOrNull();

                        if (date == null || (date.Value < dataRow.RegistryTo.Day && date.Value > dataRow.RegistryFom.Day)) continue;

                        _logger.Info($"PartThree. date.Value = {date.Value} element Click");
                        element.Click();
                        break;
                    }
                }
                CheckForError();
            }
            catch (NoSuchElementException ex)
            {
                _logger.Error($"NoSuchElementException with message = {ex.Message}");
                Error = true;
            }
            _logger.Info($"End PartThree. Error = {Error}");
        }

        public void PartFour()
        {
            _logger.Info($"Start PartFour. Error = {Error}.");
            try
            {
                Thread.Sleep(2000);
                {
                    _driver.FindElement(By.Id(registryTime)).Click();
                    _logger.Info("PartFour. registryTime Click");
                }
            }
            catch (NoSuchElementException ex)
            {
                _logger.Error($"NoSuchElementException with message = {ex.Message}");
                Error = true;
            }
            _logger.Info($"End PartFour. Error = {Error}");
        }

        private void CheckForError()
        {
            _logger.Info($"Start CheckForError. Error = {Error}");
            IWebElement erQuery = null;

            try
            {
                erQuery = _driver.FindElement(By.Id(errorMessage));
            }
            catch (NoSuchElementException ex)
            {
                _logger.Info($"Error element not found. Error ={Error}");
            }

            if (erQuery != null && erQuery.Text.IsNotBlank())
            {
                OutData = erQuery.Text;
                _logger.Error($"throw new NoSuchElementException. Reason erQuery.Text.IsNotBlank = {erQuery.Text}");
                throw new NoSuchElementException();
            }
            _logger.Info($"End CheckForError. Error = {Error}");
        }

        public void CloseBrowser()
        {
            _logger.Trace("CloseBrowser");
            _driver?.Quit();
        }
    }
}