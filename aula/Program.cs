﻿int[] vetor = new int [100];
random aleatorio = new random();

for (int i = 0; i < vetor.length; 1++){
    vetor[i] = aleatorio.next


    
}


bool troca;
do{

troca = false;
for (int i = 0; i < vetor.length - 1; i++){
    if (vetor [i] > vetor[i = 1 ]){

        int aux = vetor[i];
        vetor[i] = vetor[i + 1];
        vetor [i +1] = aux;
        troca = true;
    }
}

}while (troca == true);


