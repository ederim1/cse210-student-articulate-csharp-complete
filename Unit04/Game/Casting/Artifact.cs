namespace Unit04.Game.Casting
{
    /// <summary>
    /// <para>An item of cultural or historical interest.</para>
    /// <para>
    /// The responsibility of an Artifact is to provide the score when impacted by the actor.
    /// </para>
    /// </summary>
    public class Artifact:Actor{
            private int score = 0;

    // 2) Create the class constructor. Use the following method comment.
        
        /// <summary>
        /// Constructs a new instance of Artifact.
        /// </summary>
            public Artifact(){

            }
    // 3) Create the GetScore() method. Use the following method comment.
        /// <summary>
        /// Gets the score .
        /// </summary>
        /// <returns>The score as an int.</returns>
            public int GetScore(){
                
                return score;

            }

    // 4) Create the GetScore(int) method.
        /// <summary>
        /// Sets the artifact's score to the given value.
        /// </summary>
        /// <param name="message">The given message.</param>
            public void SetScore(int score){
                this.score = score;

            }
        }
}