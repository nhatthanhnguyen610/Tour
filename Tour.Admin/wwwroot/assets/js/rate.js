$(document).ready(function () {
    let rate = document.querySelectorAll("#rateShow")
    for (let i = 0; i < rate.length; i++) {
        let r = rate[i]
        let rResult = r.innerText
        if (rResult.includes("0,0")) {
            r.innerHTML = ``
        }
        if (rResult.includes("0,5")) {
            r.innerHTML = `<i class="fa fa-star-half text-yellow"></i>`
        }
        if (rResult.includes("1,0")) {
            r.innerHTML = `<i class="fa fa-star text-yellow"></i>`
        }
        if (rResult.includes("1,5")) {
            r.innerHTML = `<i class="fa fa-star text-yellow"></i>
                        <i class="fa fa-star-half text-yellow"></i>`
        }
        if (rResult.includes("2,0")) {
            r.innerHTML = `<i class="fa fa-star text-yellow"></i>
                        <i class="fa fa-star text-yellow"></i>`
        }
        if (rResult.includes("2,5")) {
            r.innerHTML = `<i class="fa fa-star text-yellow"></i>
                        <i class="fa fa-star text-yellow"></i>
                        <i class="fa fa-star-half text-yellow"></i>`
        }
        if (rResult.includes("3,0")) {
            r.innerHTML = `<i class="fa fa-star text-yellow"></i>
                        <i class="fa fa-star text-yellow"></i>
                        <i class="fa fa-star text-yellow"></i>`
        }
        if (rResult.includes("3,5")) {
            r.innerHTML = `<i class="fa fa-star text-yellow"></i>
                        <i class="fa fa-star text-yellow"></i>
                        <i class="fa fa-star text-yellow"></i>
                        <i class="fa fa-star-half text-yellow"></i>`
        }
        if (rResult.includes("4,0")) {
            r.innerHTML = `<i class="fa fa-star text-yellow"></i>
                        <i class="fa fa-star text-yellow"></i>
                        <i class="fa fa-star text-yellow"></i>
                        <i class="fa fa-star text-yellow"></i>`
        }
        if (rResult.includes("4,5")) {
            r.innerHTML = `<i class="fa fa-star text-yellow"></i>
                        <i class="fa fa-star text-yellow"></i>
                        <i class="fa fa-star text-yellow"></i>
                        <i class="fa fa-star text-yellow"></i>
                        <i class="fa fa-star-half text-yellow"></i>`
        }
        if (rResult.includes("5,0")) {
            r.innerHTML = `<i class="fa fa-star text-yellow"></i>
                        <i class="fa fa-star text-yellow"></i>
                        <i class="fa fa-star text-yellow"></i>
                        <i class="fa fa-star text-yellow"></i>
                        <i class="fa fa-star text-yellow"></i>`
        }
    }

    $("input[type='radio']").click(function () {
        let sim = $("input[type='radio']:checked").val()
        document.getElementById("rate").value = sim;
    })
});
