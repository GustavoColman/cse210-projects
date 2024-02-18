//this is the class for regist the eternal goals
namespace GoalTracker 
{
    public class EternalGoal : Goal 
    {
        public EternalGoal() : base()
        {
        }

        public EternalGoal(StreamReader read) : base(read)
        {
        }

        public override void Complete()
        {
            _isCompleted = false; 
            _pointsEarned += _pointsForEachCompletion;
            //this goal never complete, thats why is called a eternal goal, duh?
        }

        protected override string GetFriendlyCompleteActionDescription()
        {
            return "each time this habit is repeated";
        }

        protected override string GetFriendlyGoalTypeName()
        {
            return "eternal habit";
        }
    }
}