<script type="text/javascript">
    // locate your element and add the Click Event Listener
    document.getElementById("parent-list").addEventListener("click",function(e) {
        //if(e.target && e.target.nodeName == "LI") {
        console.log(e.target.id + " was clicked");
    }
});
</script>