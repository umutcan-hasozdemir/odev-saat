int saat, dakika, saniye, gün, beklenensaat = 1;

    for (saat = 0; saat < 24; saat++)
    {
        for (dakika = 0; dakika < 60; dakika++)
        {
            for (saniye = 0; saniye < 60; saniye++)
            {
                Console.WriteLine("dijital saat"+ "= "  + saat + ":" + dakika+ ":"+ saniye);
                
                Thread.Sleep(beklenensaat*500);
                Console.Clear();
            }
        }
    }

