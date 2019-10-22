class IndexerCreation
{
    private static int listLenght = 10;
    private int[] nums = new int[listLenght];

    public int this[int index]{
        get{
            if(index >= 0 && index <= listLenght)
            {   
               return nums[index];
            }else{
                return 0;
            }
        }
        set{
            if(index >= 0 && index <= listLenght)
            {   
               nums[index] = value;
            }            
        }
    }
}