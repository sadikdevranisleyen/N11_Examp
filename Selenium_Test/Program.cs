using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace Selenium_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            //N11 sayfası açılır.
            //driver.Navigate().GoToUrl("https://www.n11.com/");
            driver.Navigate().GoToUrl("https://wa.me/+905437355389/?text=linke+t%C4%B1klay%C4%B1n");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("")).SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(10000);
            //Tarayıcı tam ekran yapılır.
            driver.Manage().Window.Maximize();
            //Beklenir.
            System.Threading.Thread.Sleep(1000);
            //Açılan Pop-up kapatılır.
            driver.FindElement(By.ClassName("btnHolder")).Click();

            //Login bilgilerini rastgele girdiğim için login komutlarını açıklama satırına aldım.

            //// Giriş yap tıklanır.
            //driver.FindElement(By.ClassName("btnSignIn")).Click();
            ////E-Posta yazılır.
            //driver.FindElement(By.Id("email")).SendKeys("abc@gmail.com");
            ////Şifre girilir.
            //driver.FindElement(By.Id("password")).SendKeys("123456");
            ////Giriş yap butonuna tıklanır.
            //driver.FindElement(By.Id("loginButton")).Click();
            ////Beklenir.
            //System.Threading.Thread.Sleep(2000);

            //Arama yerine Krampon yazılır.
            driver.FindElement(By.Id("searchData")).SendKeys("Krampon");
            //Ara butonuna tıklanır.
            driver.FindElement(By.ClassName("searchBtn")).Click();
            // Artan fiyata göre sıralanır.
            var element = driver.FindElement(By.Id("sortingType"));
            var selectElement = new SelectElement(element);
            selectElement.SelectByValue("PRICE_LOW"); // Artan fiyatın value değerini yazıyoruz.

            //Sayfadaki ilk ürün seçilir.
            driver.FindElement(By.CssSelector("#p-328593227 > div.pro > a > img")).Click();
            //Beklenir.
            System.Threading.Thread.Sleep(1000);
            //Ayakkabı numarası seçilir.
            var shoeSize = new SelectElement(driver.FindElement(By.Id("741521292")));
            shoeSize.SelectByValue("39");
            //Renk seçilir. 
            var color = new SelectElement(driver.FindElement(By.Id("741521293")));
            color.SelectByValue("SIYAH-GUMUS");
            //Sepete ekle butonu tıklanır.
            driver.FindElement(By.CssSelector("#contentProDetail > div > div.proDetailArea > div.proDetail > div.paymentDetail > div.btnHolder > a.btn.btnGrey.btnAddBasket")).Click();
            //Beklenir.
            System.Threading.Thread.Sleep(2000);
            //Sepete git tıklanır.
            driver.FindElement(By.CssSelector("#header > div > div > div.hMedMenu > div.customMenu > div.myBasketHolder > div > div > div.text > a")).Click();
            //Beklenir.
            System.Threading.Thread.Sleep(2000);

            //Açılan Pop-up kapatılır.
            driver.FindElement(By.CssSelector("#userKvkkModal > div > div.btnHolder > span")).Click();
            //Beklenir
            System.Threading.Thread.Sleep(2000);
            //Sepetteki ürün silinir.
            driver.FindElement(By.CssSelector("#newCheckout > div > div.checkoutContainer > div.left > div.cartUpdatePartContainer > section > table.productGroup > tbody > tr > td.prodDetail > div.prodInfo > div.prodAction > span.removeProd.svgIcon.svgIcon_trash")).Click();


            
            System.Threading.Thread.Sleep(5000);


            driver.Quit();



        }
    }
}
