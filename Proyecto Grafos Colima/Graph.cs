using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Grafos_Colima
{
    class Graph
    {//Atributes
        int totalDistance;
        string finalRoute;
        int auxiliarValue;
        int cities = 12;
        private int[ , ] times = new int[12, 12];
        private  int[ , ] rutes = new int[12, 12];
        private string[,] waysS = new string[12, 12];
        private string[,] rutesS= new string[12, 12];
        int[] half1 = new int[12];
        int[] half2 = new int[12];
        string[] halfS1 = new string[12];
        string[] halfS2 = new string[12];
        string[] citiesV = new string[13];
        
        private void firstData() 
        {
            citiesV[1] = " Minatitlán ";
            citiesV[2] = " Comala ";
            citiesV[0] = " Manzanillo ";
            citiesV[3] = " Minatitlán ";
            citiesV[4] = " Villa de Álvarez ";
            citiesV[5] = " Coquimatlán ";
            citiesV[6] = " Armería ";
            citiesV[7] = " Cuauhtémoc ";
            citiesV[8] = " El Chanal ";
            citiesV[9] = " La Capacha ";
            citiesV[10] = " Colima ";
            citiesV[11] = " Tecomán ";

            times[0, 0] = 0;	//Manzanillo -	Manzanillo
            times[0, 1] = 999;	//Manzanillo -	Minatitlán
            times[0, 2] = 999;	//Manzanillo -	Comala
            times[0, 3] = 999;	//Manzanillo -	Villa de Álvarez
            times[0, 4] = 45;	//Manzanillo -	Coquimatlán
            times[0, 5] = 45;	//Manzanillo -	Armería
            times[0, 6] = 999;	//Manzanillo -	Cuauhtémoc
            times[0, 7] = 999;	//Manzanillo -	El Chanal
            times[0, 8] = 999;	//Manzanillo -	La Capacha
            times[0, 9] = 999;	//Manzanillo -	Colima
            times[0, 10] = 999;	//Manzanillo -	Ixtlahuacán
            times[0, 11] = 999;	//Manzanillo -	Tecomán

            times[1, 0] = 999;	//Minatitlán -	Manzanillo
            times[1, 1] = 0;	//Minatitlán -	Minatitlán
            times[1, 2] = 999;	//Minatitlán -	Comala
            times[1, 3] = 63;	//Minatitlán -	Villa de Álvarez
            times[1, 4] = 999;	//Minatitlán -	Coquimatlán
            times[1, 5] = 999;	//Minatitlán -	Armería
            times[1, 6] = 999;	//Minatitlán -	Cuauhtémoc
            times[1, 7] = 999;	//Minatitlán -	El Chanal
            times[1, 8] = 999;	//Minatitlán -	La Capacha
            times[1, 9] = 999;	//Minatitlán -	Colima
            times[1, 10] = 999;	//Minatitlán -	Ixtlahuacán
            times[1, 11] = 999;	//Minatitlán -	Tecomán

            times[2, 0] = 999;	//Comala -	Manzanillo
            times[2, 1] = 999;	//Comala -	Minatitlán
            times[2, 2] = 0;	//Comala -	Comala
            times[2, 3] = 9;	//Comala -	Villa de Álvarez
            times[2, 4] = 999;	//Comala -	Coquimatlán
            times[2, 5] = 999;	//Comala -	Armería
            times[2, 6] = 999;	//Comala -	Cuauhtémoc
            times[2, 7] = 999;	//Comala -	El Chanal
            times[2, 8] = 999;	//Comala -	La Capacha
            times[2, 9] = 999;	//Comala -	Colima
            times[2, 10] = 999;	//Comala -	Ixtlahuacán
            times[2, 11] = 999;	//Comala -	Tecomán

            times[3, 0] = 999;	//Villa de Álvarez -	Manzanillo
            times[3, 1] = 63;	//Villa de Álvarez -	Minatitlán
            times[3, 2] = 9;	//Villa de Álvarez -	Comala
            times[3, 3] = 0;	//Villa de Álvarez -	Villa de Álvarez
            times[3, 4] = 18;	//Villa de Álvarez -	Coquimatlán
            times[3, 5] = 999;	//Villa de Álvarez -	Armería
            times[3, 6] = 34;	//Villa de Álvarez -	Cuauhtémoc
            times[3, 7] = 999;	//Villa de Álvarez -	El Chanal
            times[3, 8] = 999;	//Villa de Álvarez -	La Capacha
            times[3, 9] = 9;	//Villa de Álvarez -	Colima
            times[3, 10] = 999;	//Villa de Álvarez -	Ixtlahuacán
            times[3, 11] = 999;	//Villa de Álvarez -	Tecomán

            times[4, 0] = 45;	//Coquimatlán -	Manzanillo
            times[4, 1] = 999;	//Coquimatlán -	Minatitlán
            times[4, 2] = 999;	//Coquimatlán -	Comala
            times[4, 3] = 18;	//Coquimatlán -	Villa de Álvarez
            times[4, 4] = 0;	//Coquimatlán -	Coquimatlán
            times[4, 5] = 49;	//Coquimatlán -	Armería
            times[4, 6] = 999;	//Coquimatlán -	Cuauhtémoc
            times[4, 7] = 999;	//Coquimatlán -	El Chanal
            times[4, 8] = 999;	//Coquimatlán -	La Capacha
            times[4, 9] = 34;	//Coquimatlán -	Colima
            times[4, 10] = 999;	//Coquimatlán -	Ixtlahuacán
            times[4, 11] = 48;	//Coquimatlán -	Tecomán

            times[5, 0] = 45;	//Armería -	Manzanillo
            times[5, 1] = 999;	//Armería -	Minatitlán
            times[5, 2] = 999;	//Armería -	Comala
            times[5, 3] = 999;	//Armería -	Villa de Álvarez
            times[5, 4] = 49;	//Armería -	Coquimatlán
            times[5, 5] = 0;	//Armería -	Armería
            times[5, 6] = 999;	//Armería -	Cuauhtémoc
            times[5, 7] = 999;	//Armería -	El Chanal
            times[5, 8] = 999;	//Armería -	La Capacha
            times[5, 9] = 999;	//Armería -	Colima
            times[5, 10] = 999;	//Armería -	Ixtlahuacán
            times[5, 11] = 14;	//Armería -	Tecomán

            times[6, 0] = 999;	//Cuauhtémoc -	Manzanillo
            times[6, 1] = 999;	//Cuauhtémoc -	Minatitlán
            times[6, 2] = 57;	//Cuauhtémoc -	Comala
            times[6, 3] = 34;	//Cuauhtémoc -	Villa de Álvarez
            times[6, 4] = 999;	//Cuauhtémoc -	Coquimatlán
            times[6, 5] = 999;	//Cuauhtémoc -	Armería
            times[6, 6] = 0;	//Cuauhtémoc -	Cuauhtémoc
            times[6, 7] = 999;	//Cuauhtémoc -	El Chanal
            times[6, 8] = 999;	//Cuauhtémoc -	La Capacha
            times[6, 9] = 21;	//Cuauhtémoc -	Colima
            times[6, 10] = 999;	//Cuauhtémoc -	Ixtlahuacán
            times[6, 11] = 999;	//Cuauhtémoc -	Tecomán

            times[7, 0] = 999;	//El Chanal -	Manzanillo
            times[7, 1] = 999;	//El Chanal -	Minatitlán
            times[7, 2] = 999;	//El Chanal -	Comala
            times[7, 3] = 999;	//El Chanal -	Villa de Álvarez
            times[7, 4] = 999;	//El Chanal -	Coquimatlán
            times[7, 5] = 999;	//El Chanal -	Armería
            times[7, 6] = 999;	//El Chanal -	Cuauhtémoc
            times[7, 7] = 0;	//El Chanal -	El Chanal
            times[7, 8] = 4;	//El Chanal -	La Capacha
            times[7, 9] = 13;	//El Chanal -	Colima
            times[7, 10] = 999;	//El Chanal -	Ixtlahuacán
            times[7, 11] = 999;	//El Chanal -	Tecomán

            times[8, 0] = 999;	//La Capacha -	Manzanillo
            times[8, 1] = 999;	//La Capacha -	Minatitlán
            times[8, 2] = 999;	//La Capacha -	Comala
            times[8, 3] = 999;	//La Capacha -	Villa de Álvarez
            times[8, 4] = 999;	//La Capacha -	Coquimatlán
            times[8, 5] = 999;	//La Capacha -	Armería
            times[8, 6] = 999;	//La Capacha -	Cuauhtémoc
            times[8, 7] = 4;	//La Capacha -	El Chanal
            times[8, 8] = 0;	//La Capacha -	La Capacha
            times[8, 9] = 13;	//La Capacha -	Colima
            times[8, 10] = 999;	//La Capacha -	Ixtlahuacán
            times[8, 11] = 999;	//La Capacha -	Tecomán

            times[9, 0] = 999;	//Colima -	Manzanillo
            times[9, 1] = 999;	//Colima -	Minatitlán
            times[9, 2] = 999;	//Colima -	Comala
            times[9, 3] = 9;	//Colima -	Villa de Álvarez
            times[9, 4] = 34;	//Colima -	Coquimatlán
            times[9, 5] = 999;	//Colima -	Armería
            times[9, 6] = 21;	//Colima -	Cuauhtémoc
            times[9, 7] = 13;	//Colima -	El Chanal
            times[9, 8] = 13;	//Colima -	La Capacha
            times[9, 9] = 0;	//Colima -	Colima
            times[9, 10] = 42;	//Colima -	Ixtlahuacán
            times[9, 11] = 41;	//Colima -	Tecomán

            times[10, 0] = 999;	//Ixtlahuacán -	Manzanillo
            times[10, 1] = 999;	//Ixtlahuacán -	Minatitlán
            times[10, 2] = 999;	//Ixtlahuacán -	Comala
            times[10, 3] = 999;	//Ixtlahuacán -	Villa de Álvarez
            times[10, 4] = 999;	//Ixtlahuacán -	Coquimatlán
            times[10, 5] = 999;	//Ixtlahuacán -	Armería
            times[10, 6] = 999;	//Ixtlahuacán -	Cuauhtémoc
            times[10, 7] = 999;	//Ixtlahuacán -	El Chanal
            times[10, 8] = 999;	//Ixtlahuacán -	La Capacha
            times[10, 9] = 42;	//Ixtlahuacán -	Colima
            times[10, 10] = 0;	//Ixtlahuacán -	Ixtlahuacán
            times[10, 11] = 34;	//Ixtlahuacán -	Tecomán

            times[11, 0] = 999;	//Tecomán -	Manzanillo
            times[11, 1] = 999;	//Tecomán -	Minatitlán
            times[11, 2] = 999;	//Tecomán -	Comala
            times[11, 3] = 999;	//Tecomán -	Villa de Álvarez
            times[11, 4] = 48;	//Tecomán -	Coquimatlán
            times[11, 5] = 14;	//Tecomán -	Armería
            times[11, 6] = 999;	//Tecomán -	Cuauhtémoc
            times[11, 7] = 999;	//Tecomán -	El Chanal
            times[11, 8] = 999;	//Tecomán -	La Capacha
            times[11, 9] = 41;	//Tecomán -	Colima
            times[11, 10] = 34;	//Tecomán -	Ixtlahuacán
            times[11, 11] = 0;	//Tecomán -	Tecomán

            waysS[0, 0] = "  ";	//Manzanillo -	Manzanillo
            waysS[0, 1] = "  ";	//Manzanillo -	Minatitlán
            waysS[0, 2] = "  ";	//Manzanillo -	Comala
            waysS[0, 3] = "  ";	//Manzanillo -	Villa de Álvarez
            waysS[0, 4] = " Manzanillo ";	//Manzanillo -	Coquimatlán
            waysS[0, 5] = " Manzanillo ";	//Manzanillo -	Armería
            waysS[0, 6] = "  ";	//Manzanillo -	Cuauhtémoc
            waysS[0, 7] = "  ";	//Manzanillo -	El Chanal
            waysS[0, 8] = "  ";	//Manzanillo -	La Capacha
            waysS[0, 9] = "  ";	//Manzanillo -	Colima
            waysS[0, 10] = "  ";	//Manzanillo -	Ixtlahuacán
            waysS[0, 11] = "  ";	//Manzanillo -	Tecomán

            waysS[1, 0] = citiesV[12];	//Minatitlán -	Manzanillo
            waysS[1, 1] = "  ";	//Minatitlán -	Minatitlán
            waysS[1, 2] = "  ";	//Minatitlán -	Comala
            waysS[1, 3] = citiesV[1];	//Minatitlán -	Villa de Álvarez
            waysS[1, 4] = "  ";	//Minatitlán -	Coquimatlán
            waysS[1, 5] = "  ";	//Minatitlán -	Armería
            waysS[1, 6] = "  ";	//Minatitlán -	Cuauhtémoc
            waysS[1, 7] = "  ";	//Minatitlán -	El Chanal
            waysS[1, 8] = "  ";	//Minatitlán -	La Capacha
            waysS[1, 9] = "  ";	//Minatitlán -	Colima
            waysS[1, 10] = "  ";	//Minatitlán -	Ixtlahuacán
            waysS[1, 11] = "  ";	//Minatitlán -	Tecomán

            waysS[2, 0] = "  ";	//Comala -	Manzanillo
            waysS[2, 1] = "  ";	//Comala -	Minatitlán
            waysS[2, 2] = "  ";	//Comala -	Comala
            waysS[2, 3] = " Comala ";	//Comala -	Villa de Álvarez
            waysS[2, 4] = " Comala ";	//Comala -	Coquimatlán
            waysS[2, 5] = "  ";	//Comala -	Armería
            waysS[2, 6] = " Comala ";	//Comala -	Cuauhtémoc
            waysS[2, 7] = "  ";	//Comala -	El Chanal
            waysS[2, 8] = "  ";	//Comala -	La Capacha
            waysS[2, 9] = "  ";	//Comala -	Colima
            waysS[2, 10] = "  ";	//Comala -	Ixtlahuacán
            waysS[2, 11] = "  ";	//Comala -	Tecomán

            waysS[3, 0] = "  ";	//Villa de Álvarez -	Manzanillo
            waysS[3, 1] = " Villa de Álvarez ";	//Villa de Álvarez -	Minatitlán
            waysS[3, 2] = " Villa de Álvarez ";	//Villa de Álvarez -	Comala
            waysS[3, 3] = "  ";	//Villa de Álvarez -	Villa de Álvarez
            waysS[3, 4] = " Villa de Álvarez ";	//Villa de Álvarez -	Coquimatlán
            waysS[3, 5] = "  ";	//Villa de Álvarez -	Armería
            waysS[3, 6] = " Villa de Álvarez ";	//Villa de Álvarez -	Cuauhtémoc
            waysS[3, 7] = "  ";	//Villa de Álvarez -	El Chanal
            waysS[3, 8] = "  ";	//Villa de Álvarez -	La Capacha
            waysS[3, 9] = " Villa de Álvarez ";	//Villa de Álvarez -	Colima
            waysS[3, 10] = "  ";	//Villa de Álvarez -	Ixtlahuacán
            waysS[3, 11] = "  ";	//Villa de Álvarez -	Tecomán

            waysS[4, 0] = " Coquimatlán ";	//Coquimatlán -	Manzanillo
            waysS[4, 1] = "  ";	//Coquimatlán -	Minatitlán
            waysS[4, 2] = "  ";	//Coquimatlán -	Comala
            waysS[4, 3] = " Coquimatlán ";	//Coquimatlán -	Villa de Álvarez
            waysS[4, 4] = "  ";	//Coquimatlán -	Coquimatlán
            waysS[4, 5] = " Coquimatlán ";	//Coquimatlán -	Armería
            waysS[4, 6] = "  ";	//Coquimatlán -	Cuauhtémoc
            waysS[4, 7] = "  ";	//Coquimatlán -	El Chanal
            waysS[4, 8] = "  ";	//Coquimatlán -	La Capacha
            waysS[4, 9] = " Coquimatlán ";	//Coquimatlán -	Colima
            waysS[4, 10] = "  ";	//Coquimatlán -	Ixtlahuacán
            waysS[4, 11] = " Coquimatlán ";	//Coquimatlán -	Tecomán

            waysS[5, 0] = " Armería ";	//Armería -	Manzanillo
            waysS[5, 1] = "  ";	//Armería -	Minatitlán
            waysS[5, 2] = "  ";	//Armería -	Comala
            waysS[5, 3] = "  ";	//Armería -	Villa de Álvarez
            waysS[5, 4] = " Armería ";	//Armería -	Coquimatlán
            waysS[5, 5] = "  ";	//Armería -	Armería
            waysS[5, 6] = "  ";	//Armería -	Cuauhtémoc
            waysS[5, 7] = "  ";	//Armería -	El Chanal
            waysS[5, 8] = "  ";	//Armería -	La Capacha
            waysS[5, 9] = "  ";	//Armería -	Colima
            waysS[5, 10] = "  ";	//Armería -	Ixtlahuacán
            waysS[5, 11] = " Armería ";	//Armería -	Tecomán

            waysS[6, 0] = "  ";	//Cuauhtémoc -	Manzanillo
            waysS[6, 1] = "  ";	//Cuauhtémoc -	Minatitlán
            waysS[6, 2] = " Cuauhtémoc ";	//Cuauhtémoc -	Comala
            waysS[6, 3] = " Cuauhtémoc ";	//Cuauhtémoc -	Villa de Álvarez
            waysS[6, 4] = "  ";	//Cuauhtémoc -	Coquimatlán
            waysS[6, 5] = "  ";	//Cuauhtémoc -	Armería
            waysS[6, 6] = "  ";	//Cuauhtémoc -	Cuauhtémoc
            waysS[6, 7] = "  ";	//Cuauhtémoc -	El Chanal
            waysS[6, 8] = "  ";	//Cuauhtémoc -	La Capacha
            waysS[6, 9] = " Cuauhtémoc ";	//Cuauhtémoc -	Colima
            waysS[6, 10] = "  ";	//Cuauhtémoc -	Ixtlahuacán
            waysS[6, 11] = "  ";	//Cuauhtémoc -	Tecomán

            waysS[7, 0] = "  ";	//El Chanal -	Manzanillo
            waysS[7, 1] = "  ";	//El Chanal -	Minatitlán
            waysS[7, 2] = "  ";	//El Chanal -	Comala
            waysS[7, 3] = "  ";	//El Chanal -	Villa de Álvarez
            waysS[7, 4] = "  ";	//El Chanal -	Coquimatlán
            waysS[7, 5] = "  ";	//El Chanal -	Armería
            waysS[7, 6] = "  ";	//El Chanal -	Cuauhtémoc
            waysS[7, 7] = "  ";	//El Chanal -	El Chanal
            waysS[7, 8] = " El Chanal ";	//El Chanal -	La Capacha
            waysS[7, 9] = " El Chanal ";	//El Chanal -	Colima
            waysS[7, 10] = "  ";	//El Chanal -	Ixtlahuacán
            waysS[7, 11] = "  ";	//El Chanal -	Tecomán

            waysS[8, 0] = "  ";	//La Capacha -	Manzanillo
            waysS[8, 1] = "  ";	//La Capacha -	Minatitlán
            waysS[8, 2] = "  ";	//La Capacha -	Comala
            waysS[8, 3] = "  ";	//La Capacha -	Villa de Álvarez
            waysS[8, 4] = "  ";	//La Capacha -	Coquimatlán
            waysS[8, 5] = "  ";	//La Capacha -	Armería
            waysS[8, 6] = "  ";	//La Capacha -	Cuauhtémoc
            waysS[8, 7] = " La Capacha ";	//La Capacha -	El Chanal
            waysS[8, 8] = "  ";	//La Capacha -	La Capacha
            waysS[8, 9] = " La Capacha ";	//La Capacha -	Colima
            waysS[8, 10] = "  ";	//La Capacha -	Ixtlahuacán
            waysS[8, 11] = "  ";	//La Capacha -	Tecomán

            waysS[9, 0] = "  ";	//Colima -	Manzanillo
            waysS[9, 1] = "  ";	//Colima -	Minatitlán
            waysS[9, 2] = "  ";	//Colima -	Comala
            waysS[9, 3] = " Colima ";	//Colima -	Villa de Álvarez
            waysS[9, 4] = " Colima ";	//Colima -	Coquimatlán
            waysS[9, 5] = "  ";	//Colima -	Armería
            waysS[9, 6] = " Colima ";	//Colima -	Cuauhtémoc
            waysS[9, 7] = " Colima ";	//Colima -	El Chanal
            waysS[9, 8] = " Colima ";	//Colima -	La Capacha
            waysS[9, 9] = "  ";	//Colima -	Colima
            waysS[9, 10] = " Colima ";	//Colima -	Ixtlahuacán
            waysS[9, 11] = " Colima ";	//Colima -	Tecomán

            waysS[10, 0] = "  ";	//Ixtlahuacán -	Manzanillo
            waysS[10, 1] = "  ";	//Ixtlahuacán -	Minatitlán
            waysS[10, 2] = "  ";	//Ixtlahuacán -	Comala
            waysS[10, 3] = "  ";	//Ixtlahuacán -	Villa de Álvarez
            waysS[10, 4] = "  ";	//Ixtlahuacán -	Coquimatlán
            waysS[10, 5] = "  ";	//Ixtlahuacán -	Armería
            waysS[10, 6] = "  ";	//Ixtlahuacán -	Cuauhtémoc
            waysS[10, 7] = "  ";	//Ixtlahuacán -	El Chanal
            waysS[10, 8] = "  ";	//Ixtlahuacán -	La Capacha
            waysS[10, 9] = " Ixtlahuacán ";	//Ixtlahuacán -	Colima
            waysS[10, 10] = "  ";	//Ixtlahuacán -	Ixtlahuacán
            waysS[10, 11] = " Ixtlahuacán ";	//Ixtlahuacán -	Tecomán

            waysS[11, 0] = "  ";	//Tecomán -	Manzanillo
            waysS[11, 1] = "  ";	//Tecomán -	Minatitlán
            waysS[11, 2] = "  ";	//Tecomán -	Comala
            waysS[11, 3] = "  ";	//Tecomán -	Villa de Álvarez
            waysS[11, 4] = " Tecomán ";	//Tecomán -	Coquimatlán
            waysS[11, 5] = " Tecomán ";	//Tecomán -	Armería
            waysS[11, 6] = "  ";	//Tecomán -	Cuauhtémoc
            waysS[11, 7] = "  ";	//Tecomán -	El Chanal
            waysS[11, 8] = "  ";	//Tecomán -	La Capacha
            waysS[11, 9] = " Tecomán ";	//Tecomán -	Colima
            waysS[11, 10] = " Tecomán ";	//Tecomán -	Ixtlahuacán
            waysS[11, 11] = "  ";	//Tecomán -	Tecomán
        }
        
        private void obtainRutes() 
        {
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (i == j)
                    {
                       rutes[i, j] = 0;
                       rutesS[i, j] += " ";
                    }
                    else
                    {
                        rutes[i, j] = j;
                        rutesS[i, j] += waysS[i, j];
                    }
                }
            }
        }
        //3
        public void obtainNewTimes()
        {
            for (auxiliarValue = 0; auxiliarValue < cities; auxiliarValue++)
            {
                for (int i = 0; i < cities; i++)
                {
                    half1[i] = times[auxiliarValue, i];
                    half2[i] = times[i, auxiliarValue];
                    halfS1[i] = waysS[auxiliarValue, i];
                    halfS2[i] = waysS[i, auxiliarValue];
                }

                for (int i = 0; i < cities; i++)
                {
                    for (int j = 0; j < cities; j++)
                    {
                        if (half2[i] == 999 || half1[j] == 999)
                        {
                            totalDistance = 999;
                        }
                        else
                        {
                            totalDistance = half2[i] + half1[j];
                            finalRoute = halfS2[i] + halfS1[j];

                            if (totalDistance < times[i, j])
                            {
                                times[i, j] = totalDistance;
                                waysS[i, j] = finalRoute;
                                rutes[i, j] = auxiliarValue;
                                //rutesS[i, j] = auxiliarValue;
                            }
                        }
                    }
                }
            }
        }
        //4
        public string bestWay(int origin, int destiny)
        {
            if (origin == destiny)
            {
               
                return "No tardarás en llegar, ya estás en la ciudad a la que quieres ir";
            }
            else
            {
                return "Tardarás " + Convert.ToString(times[origin, destiny]) + " minutos" + Environment.NewLine + "Y pasarás por "+ waysS[origin,destiny] + citiesV[destiny];
            }
        }

        public void getRute()
        {
            firstData();
            obtainRutes();
            obtainNewTimes();

        }
    }
}