(function () {
  var MAX_CHARS = 160;

  function truncateAtWord(text, maxLen) {
    if (text.length <= maxLen) {
      return text;
    }
    var cut = text.slice(0, maxLen);
    var lastSpace = cut.lastIndexOf(" ");
    if (lastSpace > maxLen * 0.55) {
      cut = cut.slice(0, lastSpace);
    }
    return cut.trim() + "\u2026";
  }

  function initQuote(el, maxChars) {
    if (el.dataset.readMoreInit === "true") {
      return;
    }

    var full = (el.textContent || "").trim();
    if (!full) {
      return;
    }

    el.dataset.readMoreInit = "true";
    el.dataset.fullText = full;

    if (full.length <= maxChars) {
      return;
    }

    var excerpt = truncateAtWord(full, maxChars);
    el.textContent = excerpt;
    el.classList.add("testimonial-text-truncated");

    var btn = document.createElement("button");
    btn.type = "button";
    btn.className = "testimonial-read-more-btn";
    btn.setAttribute("aria-expanded", "false");
    btn.textContent = "Read more";

    btn.addEventListener("click", function () {
      var expanded = btn.getAttribute("aria-expanded") === "true";
      if (expanded) {
        el.textContent = excerpt;
        el.classList.add("testimonial-text-truncated");
        btn.textContent = "Read more";
        btn.setAttribute("aria-expanded", "false");
      } else {
        el.textContent = full;
        el.classList.remove("testimonial-text-truncated");
        btn.textContent = "Read less";
        btn.setAttribute("aria-expanded", "true");
      }
    });

    el.insertAdjacentElement("afterend", btn);
  }

  function initAll() {
    document
      .querySelectorAll(".testimonial-card-items > p")
      .forEach(function (el) {
        initQuote(el, MAX_CHARS);
      });

    document
      .querySelectorAll(".testimonial-section-4 .testimonial-content h3")
      .forEach(function (el) {
        initQuote(el, 200);
      });
  }

  if (document.readyState === "loading") {
    document.addEventListener("DOMContentLoaded", initAll);
  } else {
    initAll();
  }
})();
