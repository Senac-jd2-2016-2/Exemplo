using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Game3
{

    class Contexto
    {
        public static Posicao posicaoLocal = new Posicao(450, 240);
        public static Posicao posicaoRemota = new Posicao(150, 240);
    }

    class Posicao
    {
        public int x;
        public int y;
        public int velocidade = 10;

        public Posicao(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void moverEsquerda()
        {
            x -= velocidade;
        }
        public void moverDireita()
        {
            x += velocidade;
        }
        public void moverY()
        {
            y += velocidade;
        }

        public Vector2 getVector()
        {
            return new Vector2(x, y);
        }
    }


    class ThreadComunicadora
    {
        private const int BUFFER_SIZE = 8;
        public NetworkStream stream;
        public bool server;


        private static byte[] combinar(byte[] first, byte[] second)
        {
            byte[] ret = new byte[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            return ret;
        }

        private byte[] ler()
        {
            var buffer = new byte[BUFFER_SIZE];
            var bytesReceived = stream.Read(buffer, 0, BUFFER_SIZE);
            return buffer;
        }

        private void escrever(int x, int y)
        {
            byte[] bytesx = BitConverter.GetBytes(x);
            byte[] bytesy = BitConverter.GetBytes(y);
            stream.Write(combinar(bytesx, bytesy), 0, BUFFER_SIZE);
        }

        private byte[] split(byte[] entrada, int inicio, int fim)
        {
            byte[] resultado = new byte[fim - inicio + 1];
            for (int i = inicio; i <= fim; i++)
            {
                resultado[i - inicio] = entrada[i];
            }
            return resultado;
        }

        public void executar()
        {
            while (true)
            {
                if (server)
                {
                    escrever(Contexto.posicaoLocal.x, Contexto.posicaoLocal.y);
                    byte[] remoto = ler();

                    Contexto.posicaoRemota.x = BitConverter.ToInt32(split(remoto, 0, 3), 0);
                    Contexto.posicaoRemota.y = BitConverter.ToInt32(split(remoto, 4, 7), 0);

                }
                else
                {
                    byte[] remoto = ler();
                    escrever(Contexto.posicaoLocal.x, Contexto.posicaoLocal.y);
                    byte[] bytesx = new byte[4];
                    byte[] bytesy = new byte[4];

                    Contexto.posicaoRemota.x = BitConverter.ToInt32(split(remoto, 0, 3), 0);
                    Contexto.posicaoRemota.y = BitConverter.ToInt32(split(remoto, 4, 7), 0);
                }

                Thread.Sleep(5);
            }
        }
    }
}
