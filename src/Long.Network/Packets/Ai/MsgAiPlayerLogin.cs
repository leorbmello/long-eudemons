﻿using Long.Network.Sockets;

namespace Long.Network.Packets.Ai
{
    public abstract class MsgAiPlayerLogin<T> : MsgBase<T> where T : TcpServerActor
    {
        public int Timestamp { get; set; }
        public uint Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Metempsychosis { get; set; }
        public uint[] StatusSet { get; set; } = new uint[4];
        public int BattlePower { get; set; }
        public int Life { get; set; }
        public int MaxLife { get; set; }
        public int Money { get; set; }
        public int ConquerPoints { get; set; }
        public int Nobility { get; set; }
        public int Syndicate { get; set; }
        public int SyndicatePosition { get; set; }
        public int Family { get; set; }
        public int FamilyPosition { get; set; }
        public uint MapId { get; set; }
        public ushort X { get; set; }
        public ushort Y { get; set; }

        public override void Decode(byte[] bytes)
        {
            using var reader = new PacketReader(bytes);
            Length = reader.ReadUInt16();
            Type = (PacketType)reader.ReadUInt16();
            Timestamp = reader.ReadInt32();
            Id = reader.ReadUInt32();
            Name = reader.ReadString(16);
            Level = reader.ReadInt32();
            Metempsychosis = reader.ReadInt32();

            StatusSet = new uint[reader.ReadByte()];
            for (int i = 0; i < StatusSet.Length; i++)
            {
                StatusSet[i] = reader.ReadUInt32();
            }

            BattlePower = reader.ReadInt32();
            Life = reader.ReadInt32();
            MaxLife = reader.ReadInt32();
            Money = reader.ReadInt32();
            ConquerPoints = reader.ReadInt32();
            Nobility = reader.ReadInt32();
            Syndicate = reader.ReadInt32();
            SyndicatePosition = reader.ReadInt32();
            Family = reader.ReadInt32();
            FamilyPosition = reader.ReadInt32();
            MapId = reader.ReadUInt32();
            X = reader.ReadUInt16();
            Y = reader.ReadUInt16();
        }

        public override byte[] Encode()
        {
            using var writer = new PacketWriter();
            writer.Write((ushort)PacketType.MsgAiPlayerLogin);
            writer.Write(Environment.TickCount);
            writer.Write(Id);
            writer.Write(Name, 16);
            writer.Write(Level);
            writer.Write(Metempsychosis);

            writer.Write((byte)StatusSet.Length);
            for (int i = 0; i < StatusSet.Length; i++)
            {
                writer.Write(StatusSet[i]);
            }

            writer.Write(BattlePower);
            writer.Write(Life);
            writer.Write(MaxLife);
            writer.Write(Money);
            writer.Write(ConquerPoints);
            writer.Write(Nobility);
            writer.Write(Syndicate);
            writer.Write(SyndicatePosition);
            writer.Write(Family);
            writer.Write(FamilyPosition);
            writer.Write(MapId);
            writer.Write(X);
            writer.Write(Y);
            return writer.ToArray();
        }
    }
}
