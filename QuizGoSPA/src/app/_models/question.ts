export interface Question {
    questionNumber: number,
    questiontext: string
}

export class SubjectiveQuestion implements Question {
    questionNumber: number;    
    questiontext: string;
    subjectiveId: number;
}

export class MCQ1Question implements Question {
    questionNumber: number;    
    questiontext: string;
    mcQ1Id: number;
    optionA: string;
    optionB: string;
    optionC: string;
    optionD: string;    
}

export class MCQ2Question implements Question {
    questionNumber: number;    
    questiontext: string;
    mcQ2Id: number;
    optionA: string;
    optionB: string;
    optionC: string;
    optionD: string;
}
