using POC.Models;

namespace POC.Services;

public static class PropostaService
{
    static List<Proposta>? Propostas { get; }
    
    static int Id = 1;

    static PropostaService()
    {
        Propostas = new List<Proposta> { };
    }

    public static void Add(Proposta proposta)
    {
        try
        {
            proposta.Id = Id++;

            Propostas.Add(proposta);

            MessageQueueService.AddMessage(proposta.Id.ToString());
        }
        catch (Exception)
        {

            throw;
        }
    }

    public static Proposta? Get(int id) => Propostas.FirstOrDefault(p => p.Id == id);


}
