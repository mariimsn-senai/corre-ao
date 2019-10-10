namespace SENAIzinho
{
    public class Sala
    {
        public int capacidadeAtual;
        public int capacidadeTotal; 
        public int numeroSala;
        public string[] Alunos;

        public Sala (int numeroSala, int capacidadeTotal)
        {
            this.numeroSala = numeroSala;
            this.capacidadeTotal = capacidadeTotal;
            this.capacidadeAtual = this.capacidadeTotal;
            this.Alunos = new string[capacidadeTotal];
        }
        public string AlocarAluno (string NomeAluno)
        {
            int index = 0;
            if(this.capacidadeAtual > 0)
            {
                foreach(string aluno in this.Alunos)
                {
                    if (aluno == "")
                    {
                        this.Alunos[index] = NomeAluno;
                        break;
                    }
                    index++;
                }
                this.capacidadeAtual --;
                return "ok";
                
            }else{
                return "lotado";
            }
        }
        public string RemoverAluno (string nomeAluno)
        {
            int index = 0;

            if(this.capacidadeAtual == this.capacidadeTotal)
            {
                return "SalaVazia";
            }

            foreach(string aluno in this.Alunos)
            {
                if(nomeAluno == aluno)
                {
                    this.Alunos[index] = "";
                    return "ok";
                }
                index ++;
            }
            return "NãoEncontrado";
        }
        public string MostrarAlunos()
        {
            string listaAlunos= "";
            foreach(string aluno in this.Alunos)
            {
                if(aluno != "")
                {
                    listaAlunos = listaAlunos + aluno + " ";
                }
            }
            listaAlunos.TrimEnd();
            return listaAlunos;
        }
    }
}