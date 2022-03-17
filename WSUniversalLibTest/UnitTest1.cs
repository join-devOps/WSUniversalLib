using Microsoft.VisualStudio.TestTools.UnitTesting;
using WSUniversalLib;

namespace WSUniversalLibTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class CalculationTestEasy
        {
            [TestMethod]
            public void GetQuantityForProduct_NonExistentProductType()
            {
                int count = 15;
                float width = 45;
                float length = 20;
                int productType = 4;
                int materialType = 1;

                int result = -1; // Means false

                int actual = Calculation.GetQuantityForProduct(count, width, length, productType, materialType);

                Assert.AreEqual(result, actual);
            }

            [TestMethod]
            public void GetQuantityForProduct_NonExistentMaterialType()
            {
                int count = 15;
                float width = 45;
                float length = 20;
                int productType = 3;
                int materialType = 4;

                int result = -1; // Means false

                int actual = Calculation.GetQuantityForProduct(count, width, length, productType, materialType);

                Assert.AreEqual(result, actual);
            }

            [TestMethod]
            public void GetQuantityForProduct_NonExistentMaterialAndProductTypes()
            {
                int count = 15;
                float width = 45;
                float length = 20;
                int productType = 4;
                int materialType = 4;

                int result = -1; // Means false

                int actual = Calculation.GetQuantityForProduct(count, width, length, productType, materialType);

                Assert.AreEqual(result, actual);
            }

            [TestMethod]
            public void GetQuantityForProduct_ResultProductTypeIs_1_MaterialTypeIs_1()
            {
                int count = 15;
                float width = 20;
                float length = 45;
                int productType = 1;
                int materialType = 1;

                int result = 14895; // true

                int actual = Calculation.GetQuantityForProduct(count, width, length, productType, materialType);

                Assert.AreEqual(result, actual);
            }

            [TestMethod]
            public void GetQuantityForProduct_ResultProductTypeIs_2_MaterialTypeIs_1()
            {
                int count = 15;
                float width = 20;
                float length = 45;
                int productType = 2;
                int materialType = 1;

                int result = 33852; // true

                int actual = Calculation.GetQuantityForProduct(count, width, length, productType, materialType);

                Assert.AreEqual(result, actual);
            }

            [TestMethod]
            public void GetQuantityForProduct_ResultProductTypeIs_3_MaterialTypeIs_1()
            {
                int count = 15;
                float width = 20;
                float length = 45;
                int productType = 3;
                int materialType = 1;

                int result = 114148; // true

                int actual = Calculation.GetQuantityForProduct(count, width, length, productType, materialType);

                Assert.AreEqual(result, actual);
            }

            [TestMethod]
            public void GetQuantityForProduct_ResultProductTypeIs_1_MaterialTypeIs_2()
            {
                int count = 15;
                float width = 20;
                float length = 45;
                int productType = 1;
                int materialType = 2;

                int result = 16875; // true

                int actual = Calculation.GetQuantityForProduct(count, width, length, productType, materialType);

                Assert.AreEqual(result, actual);
            }

            [TestMethod]
            public void GetQuantityForProduct_ResultProductTypeIs_2_MaterialTypeIs_2()
            {
                int count = 15;
                float width = 20;
                float length = 45;
                int productType = 2;
                int materialType = 2;

                int result = 38353; // true

                int actual = Calculation.GetQuantityForProduct(count, width, length, productType, materialType);

                Assert.AreEqual(result, actual);
            }

            [TestMethod]
            public void GetQuantityForProduct_ResultProductTypeIs_3_MaterialTypeIs_2()
            {
                int count = 15;
                float width = 20;
                float length = 45;
                int productType = 3;
                int materialType = 2;

                int result = 129324; // true

                int actual = Calculation.GetQuantityForProduct(count, width, length, productType, materialType);

                Assert.AreEqual(result, actual);
            }

            [TestMethod]
            public void GetQuantityForProduct_ResultCount_0()
            {
                int count = 0;
                float width = 20;
                float length = 45;
                int productType = 1;
                int materialType = 2;

                int result = -1; // true

                int actual = Calculation.GetQuantityForProduct(count, width, length, productType, materialType);

                Assert.AreEqual(result, actual);
            }
        }

        [TestClass]
        public class CalculationTestHard
        {
            [TestMethod]
            public void GetQuantityForProduct_ResultProductTypeIs_1_MaterialTypeIs_1_Hard()
            {
                int count = 15;
                float width = (float)20.3;
                float length = (float)45.1;
                int productType = 1;
                int materialType = 1;

                int result = 15152; // true

                int actual = Calculation.GetQuantityForProduct(count, width, length, productType, materialType);

                Assert.AreEqual(result, actual);
            }

            [TestMethod]
            public void GetQuantityForProduct_ResultProductTypeIs_2_MaterialTypeIs_1_Hard()
            {
                int count = 100;
                float width = 10;
                float length = (float)17.9;
                int productType = 2;
                int materialType = 1;

                int result = 44885; // true

                int actual = Calculation.GetQuantityForProduct(count, width, length, productType, materialType);

                Assert.AreEqual(result, actual);
            }

            [TestMethod]
            public void GetQuantityForProduct_ResultProductTypeIs_3_MaterialTypeIs_1_Hard()
            {
                int count = 99;
                float width = (float)20.3;
                float length = (float)45.9;
                int productType = 3;
                int materialType = 1;

                int result = 779968; // true

                int actual = Calculation.GetQuantityForProduct(count, width, length, productType, materialType);

                Assert.AreEqual(result, actual);
            }

            [TestMethod]
            public void GetQuantityForProduct_ResultProductTypeIs_1_MaterialTypeIs_2_Hard()
            {
                int count = 35;
                float width = 20;
                float length = (float)45.1;
                int productType = 1;
                int materialType = 2;

                int result = 39463; // true

                int actual = Calculation.GetQuantityForProduct(count, width, length, productType, materialType);

                Assert.AreEqual(result, actual);
            }

            [TestMethod]
            public void GetQuantityForProduct_ResultProductTypeIs_2_MaterialTypeIs_2_Hard()
            {
                int count = 64;
                float width = (float)20.88;
                float length = 45;
                int productType = 2;
                int materialType = 2;

                int result = 170837; // true

                int actual = Calculation.GetQuantityForProduct(count, width, length, productType, materialType);

                Assert.AreEqual(result, actual);
            }
        }
    }
}
