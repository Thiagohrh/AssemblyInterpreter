using UnityEngine;

public class RND : GenericInstruction
{
    public override void Execute(string operandum)
    {
        /*
         * Gera um valor aleatório e dentro da faixa de valores
         * definida pelos valores armazenados em AC e AC2, e armazena
         * o resultado no operando.
         */

        int randomValue = Random.Range(Registers.registry["AC"],
            Registers.registry["AC2"]);

        if (operandum.Contains("#"))
        {
            //In this case this doesnt make much sense ...
        }
        else
        {
            int memoryIndex = GetDestinationIndexOfOperandum(operandum);
            Memory.memory[memoryIndex] = randomValue.ToString();
        }

        UpdateResultsToRegistry(randomValue);
        Registers.registry["PC"]++;
    }
}
