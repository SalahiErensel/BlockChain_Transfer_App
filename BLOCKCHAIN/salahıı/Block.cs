using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;


namespace salahıı
{
    public class Block
    {
        private readonly DateTime _timeStamp;
        private long _nonce;
        public string PreviousHash { get; set; }
        public List<Transaction> Transaction { get; set; }

    public string Hash { get; private set; }

    public Block(DateTime timeStamp, List<Transaction> transaction, string previousHash = "")
    {
        _timeStamp = timeStamp;
        _nonce = 0;
        Transaction = transaction;
        PreviousHash = previousHash;
        Hash = CreateHash();
    }
    public void MineBlock(int proofOfWorkDifficulty)
    {
        string hashValidationTemplate = new String('0', proofOfWorkDifficulty);

        while (Hash.Substring(0, proofOfWorkDifficulty) != hashValidationTemplate)
        {
            _nonce++;
            Hash = CreateHash();
        }
        Console.WriteLine("Blocked with HASH={0} successfully mined!", Hash);
    }
    public string CreateHash()
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            string rawData = PreviousHash + _timeStamp + Transaction + _nonce;
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData));
            return Encoding.Default.GetString(bytes);
        }
    }
}
}
