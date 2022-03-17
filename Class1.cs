using System;

namespace WSUniversalLib
{
    public class Calculation
    {
        public static bool GetNull(int product_type, int material_type, int count)
        {
            if ((material_type > 0 && material_type < 3) && (product_type > 0 && product_type < 4) && count > 0)
                return true;
            return false;
        }

        public static double GetCountProducts(int count, float width, float length, int product_type)
        {
            if (product_type == 1)
                return count * 1.1 * width * length;
            if (product_type == 2)
                return count * 2.5 * width * length;
            else return count * 8.43 * width * length;
        }

        public static double GetBroken(int material_type)
        {
            if (material_type == 1)
                return 0.997;
            else return 0.88;
        }

        public static int GetQuantityForProduct(int count, float width, float length, int product_type, int material_type)
        {
            if (GetNull(product_type, material_type, count))
                return Convert.ToInt32(GetCountProducts(count, width, length, product_type) / GetBroken(material_type)) + 1;
            return -1;
        }
    }
}