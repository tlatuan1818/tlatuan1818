$(document).ready(function(){
    $('.size-guide-measurements__table tbody tr td').on('mouseover mouseout', function()
    {
         $(this).prevAll().addBack()
         .add($(this).parent().prevAll()
         .children(':nth-child(' + ($(this).index() + 1) + ')')).toggleClass('is-hightlight');
    }); 
});
$(document).ready(function(){
    $('.size-guide-measurements__table tr th.size-guide-table-lead-column').hover( function()
    {
         $(this).addClass('is-hightlight');
    },function()
    {
        $(this).removeClass('is-hightlight');
    }); 
});
$(document).ready(function(){
    $('.size-guide-measurements__table tr td').hover( function()
    {
         $(this).addClass('is-focused');
    },function()
    {
        $(this).removeClass('is-focused');
    }); 
});
