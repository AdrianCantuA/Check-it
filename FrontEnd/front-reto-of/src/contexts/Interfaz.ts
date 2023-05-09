export interface Users {
    iD_user: Number;
    userName: string;
    lastName: string;
    email: string;
    password: String;
  }
  
  export interface Score {
    iD_Score: number;
    iD_Game: Number;
    iD_user: number;
    attempt_number: Number;
    score: Number;
    play_time: Number;
    play_date: Date;
    completed: Boolean;
  }

  export interface Games {
    iD_Game: Number;
    game_name:String;
    game_description?: String;
    area: String;
  }
  

  