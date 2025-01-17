﻿using Long.Kernel;
using Long.Network;
using Long.Network.Security;
using Long.Network.Sockets;
using System.Net.Sockets;

namespace Long.Game.Network.Login
{
    public sealed class LoginServer : TcpServerActor
    {
        private static ServerSettings.LoginClient settings;

        static LoginServer()
        {
            var serverSettings = new ServerSettings();
            settings = serverSettings.Login;
        }

#if DEBUG_PALADIN
        public LoginServer(Socket socket, Memory<byte> buffer, uint readPartition = 0, uint writePartition = 0)
            : base(socket, buffer, null, readPartition, writePartition, "")
        {
            DiffieHellman = DiffieHellman.Create();
        }
#else
        public LoginServer(Socket socket, Memory<byte> buffer, uint readPartition = 0, uint writePartition = 0) 
            : base(socket, buffer, AesCipher.Create(settings.Encryption.Key, settings.Encryption.EncryptIV, settings.Encryption.DecryptIV),
                  readPartition, writePartition, NetworkDefinition.ACCOUNT_FOOTER)
        {
            DiffieHellman = DiffieHellman.Create();
        }
#endif

        public DiffieHellman DiffieHellman { get; }

        public override Task SendAsync(byte[] packet)
        {
            LoginClientSocket.Instance?.Send(this, packet);
            return Task.CompletedTask;
        }

        public override Task SendAsync(byte[] packet, Func<Task> task)
        {
            LoginClientSocket.Instance?.Send(this, packet, task);
            return Task.CompletedTask;
        }
    }
}
