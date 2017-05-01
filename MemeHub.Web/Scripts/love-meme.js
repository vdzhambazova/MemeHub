$(function () {
    var memeId = $('#article-container').attr('meme-id');
    $('#btn-love').on('click', function() {
        loveMeme(memeId);
    });
});

function loveMeme(memeId) {
    $.ajax({
        url: memeId + "/loveMeme",
        type: "get",
        success: function () {
            var currentMemePoints = $('#meme-points').text();
            currentMemePoints++;
            $('#meme-points').text(currentMemePoints);
        }
    });
}