using manager;

namespace Metadata
{
    public class Skill
    {
    }

    public class FireBall : Skill
    {
        public void effect(BattleManager mgr)
        {
            Monster target = mgr.ChooseOneMonsterTarget();
            target.dealDamage(2);
        }
    }
}