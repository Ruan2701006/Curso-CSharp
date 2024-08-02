using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC_
{
    public static class TiposPrimitivos
    {

        public static void ImprimirTipos()
        {
            //Tipo inteiro de 8 bits com sinal 
            sbyte SByte = -128; //Valores variam de -128 a 127 
            Console.WriteLine($"sbyte: {SByte}");

            //Tipo inteiro de 16 bits com sinal 
            byte variavelByte = 255; //Valores variam de 0 a 255 
            Console.WriteLine($"byte: {variavelByte}");

            //Tipo inteiro de 16 bits com sinal 
            short variavelShort = -32768; //Valores variam de -32768 a 32768 
            Console.WriteLine($"short: {variavelShort}");

            //Tipo inteiro de 16 bits com sinal 
            ushort variavelUShort = 65535; //Valores variam de 0 a 65535 
            Console.WriteLine($"Ushort: {variavelUShort}");

            //Tipo inteiro de 32 bits com sinal 
            sbyte variavelInit = ; //Valores variam de 0 a 255 
            Console.WriteLine($"init: {variavelInit}");

            //Tipo inteiro de 64 bits com sinal 
            long variavelLong = -922337203654775888; //Valores variam de -922337203654775888 
            Console.WriteLine($"long: {variavelLong}");

            //Tipo inteiro de 64 bits com sinal 
            ulong variavelUlong = 18446744973709551615; //Valores variam de 0 a 18446744973709551615
            Console.WriteLine($"ulong: {variavelUlong}");

            //Tipo de ponto flutuante de 32 bits 
            ulong variavelFloat = 3.14f; // 
            Console.WriteLine($"float: {variavelFloat}");

            //Tipo de ponto flutuante de 64 bits  
            ulong variavelDouble = 3.141592653589793; //
            Console.WriteLine($"double : {variavelDouble}");
        }

    }
}
